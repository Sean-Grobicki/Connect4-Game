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
    public partial class Counter : UserControl
    {
        private int _counterColour;

        public Counter(int counterColour)
        {
            InitializeComponent();
            _counterColour = counterColour;
        }

        private void Counter_Load(object sender, EventArgs e)
        {
            switch (_counterColour)// Will decide what image to load to represent that counter colour.
            {
                case 1: this.BackgroundImage = Connect4_v10.Properties.Resources.Red_Counter;
                    this.Height = Connect4_v10.Properties.Resources.Red_Counter.Height;
                    this.Width = Connect4_v10.Properties.Resources.Red_Counter.Width;
                    break;
                case 2: this.BackgroundImage = Connect4_v10.Properties.Resources.Blue_Counter;
                    this.Height = Connect4_v10.Properties.Resources.Blue_Counter.Height;
                    this.Width = Connect4_v10.Properties.Resources.Blue_Counter.Width;
                    break;
                case 3: this.BackgroundImage = Connect4_v10.Properties.Resources.Green_Counter;
                    this.Height = Connect4_v10.Properties.Resources.Green_Counter.Height;
                    this.Width = Connect4_v10.Properties.Resources.Green_Counter.Width;
                    break;
                case 4: this.BackgroundImage = Connect4_v10.Properties.Resources.Yellow_Counter;
                    this.Height = Connect4_v10.Properties.Resources.Yellow_Counter.Height;
                    this.Width = Connect4_v10.Properties.Resources.Yellow_Counter.Width;
                    break;
                case 5: this.BackgroundImage = Connect4_v10.Properties.Resources.Purple_Counter;
                    this.Height = Connect4_v10.Properties.Resources.Purple_Counter.Height;
                    this.Width = Connect4_v10.Properties.Resources.Purple_Counter.Width;
                    break;
                case 6: this.BackgroundImage = Connect4_v10.Properties.Resources.pink_counter;
                    this.Height = Connect4_v10.Properties.Resources.pink_counter.Height;
                    this.Width = Connect4_v10.Properties.Resources.pink_counter.Width;
                    break;

            }
        }
    }
}
