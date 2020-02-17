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
    public partial class Winner : Form
    {
        public Winner(string pn)
        {
            InitializeComponent();
            Player.Text = pn;// Displays winner message to the winner.
        }


        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PlayAgain_Click(object sender, EventArgs e)// If they click play again button will play again otherwise will exit.
        {
            Main_Menu m = new Main_Menu();
            m.Show();
            m.Closed += (s, args) => this.Close();
            this.Hide();
        }

    }
}
