using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Connect4_v10
{
    public partial class Connect_4 : Form
    {
        private Board _board= new Board();
        private User _u1;
        private User _u2;
        private BoardUserCtr buc = new BoardUserCtr();
        private List<int> moveHistory = new List<int>();
        private bool _isSP;
        private int _depth;

        public Connect_4(User u1,User u2,bool isSP)// Constructor called if it's a new game
        {
            InitializeComponent();
            _u1 = u1;
            _u2 = u2;
            _u2.CurrentUser = false;
            _isSP = isSP;
            _u1.CurrentUser = true;
            playerTurn.Text = "Player 1";
        }
        public Connect_4(User u1, User u2,int pTurn,List<int> mh,bool isSP)//Constructor called if it's a loaded game.
        {
            InitializeComponent();
            buc.Parent = this;
            _u1 = u1;
            _u2 = u2;
            _isSP = isSP;
            bool move = true;
            if (pTurn == 1)
            {
                _u1.CurrentUser = true;
                _u2.CurrentUser = false;
                playerTurn.Text = "Player 1";
            }
            else
            {
                _u2.CurrentUser = true;
                _u1.CurrentUser = false;
                playerTurn.Text = (_isSP ? "AI" : "Player 2");
            }
            foreach (int c in mh)// Will fill up the board as well as the counter history to represent the board and also allow redos once reloaded.
            {
                if (move)//will switch between users so corrrect colour counters are placed.
                {
                    int r = _u1.playerMove(c, _board.Board1);
                    buc.addCounter(c, _u1.CounterColour,r );
                    _board.Board1[r,c] = _u1.CounterColour;
                }
                else
                {
                    int r = u2.playerMove(c, _board.Board1);
                    buc.addCounter(c, _u2.CounterColour, r);
                    _board.Board1[r,c] = _u2.CounterColour;
                }
                move = !move;
                moveHistory.Add(c);
            }
        }

        public void Connect_4_Load(object sender, EventArgs e)
        {
            Left = Top = 0;
            buc.Parent = this;
            this.WindowState = FormWindowState.Maximized;
            Won.Top += 20;
            Won.Left = buc.Left + 200;
            buc.moveIsMade += new System.EventHandler(this.move_Made); // Allows the buttons to be inside user control.
        }

        private void move_Made(object sender, EventArgs e)
        {
            makeTurn(buc.getMove());
        }
        private void makeTurn(int col)// called after either button pressed or ais decided and is passed the column of where moves going to be placed.
        {
            int counterColour = 0;
            bool moveWorked = false;
            int row = 0;
            notWorked.Visible = false;
            if (_board.boardFull())// checks if the board is full to decide whether game can continue and hides all buttons if not and displays message..
            {
                Won.Visible = true;
                Won.Text = "Nobody has won and board is full. Click here to Continue.";
                buc.stopGame();
            }
            else
            {
                moveWorked = makeMove(col,ref counterColour,ref row);
                if (moveWorked)// Will only be passed if the move was valid.
                {
                    buc.addCounter(col, counterColour, row);//adds the counter visually onto the board.
                    moveHistory.Add(col);//adds move to the movehsitory.
                    if (_board.checkWin(col, row, counterColour))//Will check if the 
                    {
                        Won.Visible = true;
                        Won.Text = "Player " + (_u1.CurrentUser ? "1" : "2") + " has won. Click here to continue.";
                        buc.stopGame();
                    }
                    else
                    {
                        _board.changeUser(_u1, _u2);// changes who the current user is.
                        if (_isSP)
                        {
                            makeAINextTurn((AI)_u2);
                        }
                        else
                        {
                            playerTurn.Text = "Player " + (_u1.CurrentUser ? "1" : "2");
                        }
                    }
                }
                else
                {
                    notWorked.Visible = true;
                }
            }
       }

        public void makeAINextTurn(AI ai)
        {
            _depth = ai.Depth;
            if (_u1.CurrentUser)
            {
                playerTurn.Text = "Player 1";
            }
            else//only called when singleplayer and ais turn.
            {
                playerTurn.Text = "AI";

                int c = ai.bestMove(_board.Board1,_u1.CounterColour);//Will choose the best option for ai to move.
                makeTurn(c);// will recall makemove for ais move to be placed.
            }
        }

        public bool makeMove(int col,ref int counterColour,ref int row)
        {
            if (_u1.CurrentUser)
            {
                row = _u1.playerMove(col, _board.Board1);//this checks if the move they want to make is valid and if not they will be urged to choose different button.
                if (row != -1)
                {
                    counterColour = _u1.CounterColour;
                    _board.Board1[row, col] = counterColour;//if its valid then the counter will be placed in position with corrrect counter colour.
                    return true;
                }
            }
            else
            {
                row = _u2.playerMove(col, _board.Board1);
                if (row != -1)
                {
                    counterColour = _u2.CounterColour;
                    _board.Board1[row, col] = counterColour;
                    return true;
                }
            }
            return false;
        }
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void save_Click(object sender, EventArgs e)// Called if save button clicked.
        {
            if (_isSP)
	        {
                //change for difficuly
		        saveGame sg = new saveGame(_board.Board1,1,_isSP,_u1.CounterColour,_u2.CounterColour,moveHistory,_depth);//Opens the save game form where you name your game to save it for singleplayer.
                sg.Show();
                sg.Closed += (s, args) => this.Close();
                this.Hide();
            }
            else
            {
                int pt = 1;
                if (_u2.CurrentUser)
	            {
		            pt = 2;
	            }
                saveGame sg = new saveGame(_board.Board1,pt,_isSP,_u1.CounterColour,_u2.CounterColour,moveHistory,-1);//Opens the save game form where you name your game to save it for multiplayer.
                sg.Show();
                sg.Closed += (s, args) => this.Close();
                this.Hide();
            }

        }

        private void Won_Click(object sender, EventArgs e)//Can only click when visible after the games won.
        {
            if (_board.boardFull())//if board was full takes to main menu otherwise takes you to winner form.
            {
                Main_Menu m = new Main_Menu();
                m.Show();
                m.Closed += (s, args) => this.Close();
                this.Hide();
            }
            else
            {
                Winner w = new Winner("Player " + (_u1.CurrentUser ? "1" : "2"));
                w.Show();
                w.Closed += (s, args) => this.Close();
                this.Hide();
            }
        }

        private void home_Click(object sender, EventArgs e)// Takes you to main menu form.
        {
            Main_Menu m = new Main_Menu();
            m.Show();
            m.Closed += (s, args) => this.Close(); 
            this.Hide();

        }

        private void undo_Click(object sender, EventArgs e)
        {
            if (moveHistory.Count > 0)// As long as one move has been taken will allow undo.
            {
                backMove();
                if (_isSP)
                {
                    backMove();// if singleplayer it needs to be called twice.
                }
                else
                {
                    playerTurn.Text = "Player " + (_u1.CurrentUser ? "1" : "2");
                }
            }  
        }


        private void backMove()
        {
            buc.removeCounter();// removes counter visually from the board.
            int r = 0;
            r = _u1.playerMove(moveHistory[moveHistory.Count - 1], _board.Board1) - 1;
            _board.Board1[r,moveHistory[moveHistory.Count-1]] = 0;// Will see where the counter was placed and remove from the board.
            _board.changeUser(_u1, _u2);// changes the user.
            moveHistory.RemoveAt(moveHistory.Count-1);// Removes that counter from the move history.
        }
    }

}

