using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Connect4_v10
{
    public partial class Counter_Chooser : Form
    {
        private bool _isMP;
        private int _playerCount = 0;
        private User _p1;
        private int _colourNumber;
        private int _otherUserColour;

        public Counter_Chooser(bool isMP)
        {
            InitializeComponent();
            _isMP = isMP;
        }

        public Counter_Chooser(bool isMP,int playerCount,User p1,int oUC)
        {
            InitializeComponent();//This constructer called if its multiplayer and the second user in order to save the first users information.
            _playerCount = playerCount;
            _p1 = p1;
            _isMP = isMP;
            _otherUserColour = oUC;
            player.Text = "Player 2";
        }

        private void purple_Click(object sender, EventArgs e)
        {
            _colourNumber = 6;
            userChecker();
        }

        private void red_Click(object sender, EventArgs e)
        {
            _colourNumber = 1;// For each different colour a number is assigned to represent it and is set depending on the button they click.
            userChecker();
        }

        private void blue_Click(object sender, EventArgs e)
        {
            _colourNumber = 2;
            userChecker();
        }

        private void yellow_Click(object sender, EventArgs e)
        {
            _colourNumber = 4;
            userChecker();
        }

        private void green_Click(object sender, EventArgs e)
        {
            _colourNumber = 3;
            userChecker();
        }

        private void pink_Click(object sender, EventArgs e)
        {
            _colourNumber = 5;
            userChecker();
        }

        private void userChecker()
        {
            int userCounter = 0;
            if (_isMP && _playerCount == 1)
            {
                if(_otherUserColour == _colourNumber)
                {
                    AIU.Visible = true;
                    return;
                }
                User p2 = new User(_colourNumber);
                Connect_4 f = new Connect_4(_p1, p2,false);//If its the second user on multiplayer they will both be assigned the colours and the game will be open.
                f.Closed += (s, args) => this.Close();
                f.Show();
                this.Hide();
            }
            else if (_isMP && _playerCount == 0)
            {
                _playerCount++;
                User p1 = new User(_colourNumber);
                Counter_Chooser c = new Counter_Chooser(_isMP,_playerCount, p1,p1.CounterColour);//If its multiplayer but first user then player 1s counter colour assigned and counter chooser called again for player 2.
                c.Closed += (s, args) => this.Close();
                c.Show();
                this.Hide();

            }
            else
            {
                do
                {
                    Random r = new Random();
                    userCounter = r.Next(1, 6);
                } while (userCounter == _colourNumber);// Will choose a random colour for the ai making sure it doesn't clash with the users.
                User player1 = new User(_colourNumber);
                AI player2 = new AI(userCounter);
                Difficulty f = new Difficulty(player1, player2);// The ai and user are assingned there colours then the difficulty form is called.
                f.Closed += (s, args) => this.Close();
                f.Show();
                this.Hide();
                
            }  
        }

        private void home_Click(object sender, EventArgs e)
        {
            Main_Menu m = new Main_Menu();//Will go back to home menu if clicked.
            m.Closed += (s, args) => this.Close();
            this.Hide();
            m.Show();
        }

        }
}
