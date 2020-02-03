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
    public partial class Difficulty : Form
    {

        private User _u1;
        private AI _ai;
        public Difficulty(User u1, AI ai)
        {
            InitializeComponent();
            _u1 = u1;// assigns the users to be used in this form.
            _ai = ai;
        }

        private void easy_Click(object sender, EventArgs e)
        {
            _ai.Depth = 1;
            Connect_4 f = new Connect_4(_u1, _ai);//Will open the game assigning the difficulty to the ai depending on which button the user clicked. Each number represents a different difficulty.  
            f.Show();
            this.Close();
        }

        private void medium_Click(object sender, EventArgs e)
        {
            _ai.Depth = 2;
            Connect_4 f = new Connect_4(_u1, _ai);
            f.Show();
            this.Close();
        }

        private void hard_Click(object sender, EventArgs e)
        {
            _ai.Depth = 3;
            Connect_4 f = new Connect_4(_u1, _ai);
            f.Show();
            this.Close();
        }

        private void home_Click(object sender, EventArgs e)
        {
            Main_Menu m = new Main_Menu();
            m.Show();
            this.Close();
        }

    }
}
