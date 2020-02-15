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
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void Singleplayer_Click(object sender, EventArgs e)
        {
            Counter_Chooser f = new Counter_Chooser(false);//If singleplayer chosen then will open counter chooser with false for singleplayer.
            f.Closed += (s, args) => this.Close();
            f.Show();
            this.Hide();
        }

        private void Multiplayer_Click(object sender, EventArgs e)
        {
            Counter_Chooser f = new Counter_Chooser(true);//If multiplayer then will open counter chooser with true to represent multiplayer.
            f.Closed += (s, args) => this.Close();
            f.Show();
            this.Hide();
        }

        private void loadGame_Click(object sender, EventArgs e)
        {
            label2.Visible = true;// Allows textbox be shown to type the games name.
            textBox1.Visible = true;
            ld.Visible = true;
        }

        private void Load_Click(object sender, EventArgs e)
        {
                
        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {

        }

        private void ld_Click(object sender, EventArgs e)
        {
            OleDbConnection c = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\Sean\Desktop\MAJOR PROJECT\Connect4 v10\Resources\Saved Games.accdb'");
            c.Open();
            OleDbDataAdapter da1 = new OleDbDataAdapter(@"SELECT Columns FROM MoveHistory WHERE GameName = ?", c);//Loads all the movehistory from that game from the database.
            OleDbParameter p1 = new OleDbParameter();
            p1.ParameterName = @"?";
            p1.Value = textBox1.Text.ToString();
            da1.SelectCommand.Parameters.Add(p1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            List<int> mh = new List<int>();
            foreach (DataRow r in dt1.Rows)
            {
                mh.Add((int)r["Columns"]);// Adds the movehistory into list as length is not fixed.
            }
            OleDbDataAdapter da2 = new OleDbDataAdapter(@"SELECT * FROM Game WHERE GameName = gn", c);// Gets all the other information needed to load the game.
            OleDbParameter p2 = new OleDbParameter();
            p2.ParameterName = @"gn";
            p2.Value = textBox1.Text.ToString();
            da2.SelectCommand.Parameters.Add(p2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            c.Close();
            foreach (DataRow r in dt2.Rows)
            {
                bool isSP = (bool)r["isSP"];
                User u1 = new User((int)r[@"P1CounterNum"]);// Stores the values into the User classes so can be used in game. 
                if (isSP)
                {
                    AI ai = new AI((int)r[@"P2CounterNum"]);
                    ai.Depth = (int)r[@"Difficulty"];
                    Connect_4 c4 = new Connect_4(u1, ai, 1 ,mh);//Opens the connect 4 game with the two users and movehistory if singleplayer.
                    this.Hide();
                    c4.Show();
                }
                else
                {
                    User u2 = new User((int)r[@"P2CounterNum"]);
                    int pt = (int)r[@"PlayerTurn"];
                    Connect_4 c4 = new Connect_4(u1, u2,pt, mh);//Opens the connect 4 game with two users and movehistory when multiplayer.
                    this.Hide();
                    c4.Show();
                }

            }
            gameName.Visible = true;
        }
    }
}
