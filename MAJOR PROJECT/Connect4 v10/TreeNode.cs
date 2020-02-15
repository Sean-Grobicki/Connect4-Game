﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Connect4_v10
{
    public class TreeNode
    {
        private int score;
        private int[,] moveBoard;
        private int row;
        private int col;
        private int counterColour;
        private bool yourMove;
        private int depth;

        public TreeNode[] moves = new TreeNode[7];

        public int Score { get => score; set => score = value; }

        public TreeNode(int[,] board, int c, int r, bool yourMove, int cC, int oppCounterColour,int depth)
        {
            this.yourMove = yourMove;
            this.depth = depth;
            if (yourMove)
            {
                this.counterColour = cC;
            }
            else
            {
                this.counterColour = oppCounterColour;
            }
            col = c;
            row = r;
            copyBoard(board);
            if (row != -1)
            {
                moveBoard[row, col] = counterColour;
            }
            if (depth > 0)
            {
                createBranches(yourMove,cC,oppCounterColour);
            }
            Score = calculateScore();
        }

        public TreeNode(int[,] board,int cC, int oppCounterColour,int depth)
        {
            this.depth = depth;
            copyBoard(board);
            createBranches(false,cC, oppCounterColour);
        }

        public void createBranches(bool yourMove, int cC, int oppCounterColour)
        {
            for (int i = 0; i < moves.Length; i++)
            {
                int r = playerMove(moveBoard,i);
                if (r != -1)
                {
                    moves[i] = new TreeNode(moveBoard, i, r , !yourMove, cC, oppCounterColour, depth - 1);
                }
            }
        }
        public void copyBoard(int[,] board)
        {
            moveBoard = new int[6,7];
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    moveBoard[i, j] = board[i, j];
                }
            }
        }

        public int calculateScore()
        {
            double score = checkAdjacent(0, 1) + checkAdjacent(1, 0) + checkAdjacent(1, 1) + checkAdjacent(-1, 1) + checkAdjacent(1, -1) + checkAdjacent(-1, -1);
            return (int)score;
        }

        public double checkAdjacent(int x, int y)
        {
            int count = 0;
            while (row - y >= 0 && row - y < 6 && col - x >= 0 && col - x < 7 && moveBoard[row - y, col - x] == counterColour)// will shift to the left as to not miss out on counters if placed in middle.
            {
                row -= y;
                col -= x;
            }
            while (row + y >= 0 && row + y < 6 && col + x >= 0 && col + x < 7 && moveBoard[row + y, col + x] == counterColour)//will count across then how many counters of same colour are next to it.
            {
                row += y;
                col += x;
                count++;
            }
            return Math.Pow(count, 2);
        }

        public int playerMove(int[,] board,int move)
        {
            for (int r = 0; r < 6; r++)// will find the first available spot where a move could be placed using the column otherwise will return -1.
            {
                if (board[r, move] == 0)
                {
                    return r;
                }
            }
            return -1;
        }
        public bool checkWin()
        {
            if (Board.checkWin(col, row, counterColour, moveBoard))
            {
                return true;
            }
            return false;
        }
    }


}
