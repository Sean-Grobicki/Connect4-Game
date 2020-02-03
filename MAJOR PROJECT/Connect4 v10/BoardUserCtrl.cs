using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Connect4_v10
{
    public partial class BoardUserCtr : UserControl
    {
        private Point col1 = new Point(3,605);// the coordinates of the bottom position of the counters on the board.
        private Point col2 = new Point(123,605);
        private Point col3 = new Point(243,605);
        private Point col4 = new Point(363,605);
        private Point col5 = new Point(483,605);
        private Point col6 = new Point(603,605);
        private Point col7 = new Point(723,605);
        private List<Counter> counterHistory = new List<Counter>();

        public BoardUserCtr()
        {
            InitializeComponent();
        }

        public void addCounter(int[,] board,int col,int counterColour,int row)
        {
            Point correctCol = new Point();
            switch (col)// chooses coordinate to modify depending on the column.
	        {
                case 0: correctCol = col1;
                    break;
                case 1: correctCol = col2;
                    break;
                case 2: correctCol = col3;
                    break;
                case 3: correctCol = col4;
                    break;
                case 4: correctCol = col5;
                    break;
                case 5: correctCol = col6;
                    break;
                case 6: correctCol = col7;
                    break;
	        }

            Point pos = new Point();
            Counter c = new Counter(counterColour);
            pos.X = correctCol.X;                        
            pos.Y = correctCol.Y-(120*(row));// changes position of how far up it is depending on where its supposed to be.
            c.Parent= this;
            c.Location = pos;
            c.Visible = true;
            this.SendToBack();
            c.BringToFront();
            counterHistory.Add(c);// adds the counter to counter history so it can be removed if needed.
        }

        public void removeCounter()
        {
            counterHistory[counterHistory.Count - 1].Visible = false;// will remove the counter from the board and will remove it from the counter history.
            counterHistory.RemoveAt(counterHistory.Count - 1);
        }

        private void BoardUserCtr_Load(object sender, EventArgs e)
        {

        }
    }
}
