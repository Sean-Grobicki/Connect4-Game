using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Connect4_v10
{
    public class User
    {
        protected int _counterColour;// stores number representing colour of the counter.

        public int CounterColour
        {
            get { return _counterColour; }
            set { _counterColour = value; }
        }
        protected bool _currentUser = false;// stores whether its the current user.
        public bool CurrentUser
        {
            get { return _currentUser; }
            set { _currentUser = value; }
        }

        public User(int counterColour)// creating user requires the number representing the counter colour.
        {
            _counterColour = counterColour;
        }
        public User()
        { 
        
        }

        public int playerMove(int col,int[,] board)
        {
            for (int row = 0; row < 6; row++)// will find the first available spot where a move could be placed using the column otherwise will return -1.
            {
                if (board[row, col] == 0)
                {
                    return row;
                }
            }
            return -1;
        }
    }
}
