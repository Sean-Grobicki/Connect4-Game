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
    public partial class saveGame : Form
    {
        private int _playerTurn;
        private int[,] _board = new int[6, 7];
        private bool _isSP;
        private int _p1CounterNum;
        private int _p2CounterNum;
        private List<int> _moveHistory = new List<int>();
        private int _difficulty;

        public saveGame(int[,] b, int pT, bool iSP, int p1, int p2,List<int> mh,int depth)//constructor takes the values that are needed to save the game.
        {
            InitializeComponent();
            _playerTurn = pT;
            _isSP = iSP;
            _p1CounterNum = p1;
            _p2CounterNum = p2;
            _difficulty = depth;
            foreach (int c in mh)
            {
                _moveHistory.Add(c);
            }
            
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    _board[j, i] = b[j, i];
                }
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            OleDbConnection c = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\Sean\Desktop\MAJOR PROJECT\Connect4 v10\Resources\Saved Games.accdb'");
            OleDbCommand sql = new OleDbCommand();
            sql.CommandType = CommandType.Text;
            sql.CommandText = @"INSERT INTO Game(PlayerTurn,isSP,P1CounterNum,p2CounterNum,Difficulty,GameName) VALUES(?,?,?,?,?,?)";// will put all the information about the game into the database to load at a later date.
            sql.Parameters.AddWithValue(@"PlayerTurn", _playerTurn);
            sql.Parameters.AddWithValue(@"isSP", _isSP);
            sql.Parameters.AddWithValue(@"P1CounterNum", _p1CounterNum);
            sql.Parameters.AddWithValue(@"P2CounterNum", _p2CounterNum);
            sql.Parameters.AddWithValue(@"Difficulty",_difficulty);
            sql.Parameters.AddWithValue(@"GameName", textBox.Text);
            sql.Connection = c;
            c.Open();
            sql.ExecuteNonQuery();
            c.Close();
            foreach (int col in _moveHistory)
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"INSERT INTO MoveHistory(Columns,GameName) VALUES(?,?)";//Will put the move history into the database to be loaded at a later date.
                cmd.Parameters.AddWithValue(@"Columns", col);
                cmd.Parameters.AddWithValue(@"GameName",textBox.Text);
                cmd.Connection = c;
                c.Open();
                cmd.ExecuteNonQuery();
                c.Close();
            }
            Main_Menu m = new Main_Menu();// will bring you back to the main menu once saved.
            m.Show();
            this.Close();
        }

        private void saveGame_Load(object sender, EventArgs e)
        {

        }
    }
}
