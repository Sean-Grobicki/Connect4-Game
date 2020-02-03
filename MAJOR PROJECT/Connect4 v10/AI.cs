using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Connect4_v10
{
    public class AI:User
    {
        private int depth;// stores the amount of steps it will look ahead ranging from 1 to 3.

        public int Depth
        {
            get { return depth; }
            set { depth = value; }
        }
        public AI(int uc)
        {
            _counterColour = uc;
        }
        public int bestMove(int depth,string boardString,int counterColour,int oppCounterColour,int[] moveScores,bool aiMove,int prevCol)
        {
            int[,] board = convertToBoard(boardString);// Converts board back from string as local copy of board needed and arrays when passed store public.
            for (int i = 0; i < 7; i++)// Check all possible 7 columns.
            {
                int r = playerMove(i, board);
                if (r == -1 && prevCol == -1)
                {
                    moveScores[i] -= 5000;// if the move is invalid then subtract large number so move won't happen only if checking 1 step ahead.
                }
                else if (r == -1) {}// ignore this as move cant be placed and won't affect success of move.
                else
                {
                    if (aiMove)// checks opposition move if true.
                    {
                        board[r, i] = oppCounterColour;
                        if (Board.checkWin(i, r, oppCounterColour, board))// will check if opposition can win by placing here.
                        {
                            if (prevCol == i)// if its checking more than move ahead subtract as dont want to move but if not then you want to mave there as otherwise the ai will lose.
                            {
                                moveScores[i] -= 5000;
                            }
                            else
                            {
                                moveScores[i] += 5000;
                            }

                        }
                        moveScores[i] += getScore(board, oppCounterColour, r, i);// retrieves the score of that move and adds to score of that column.
                        if (depth > 1)
                        {
                            bestMove(depth - 1, convertToString(board), counterColour, oppCounterColour, moveScores, false, prevCol);// if there are more moves to check ahead then recursively call routine.
                        }
                    }
                    else// checking own moves.
                    {
                        board[r, i] = counterColour;
                        if (Board.checkWin(i, r, counterColour, board))// checks if it can win by placing it here.
                        {
                            if (prevCol != -1)
                            {
                                if (prevCol == i)//if the previous column hasnt actually been placed then don't block your own move othrewise you'll want to play trhe counter there.
                                {
                                    moveScores[i] -= 5000;
                                }
                                else
                                {
                                    moveScores[i] += 5000;
                                }
                            }
                            else
                            {
                                moveScores[i] += 5000;// If it's the first round of checking then this move will make you win so automatically place there.
                                return i;
                            }
                        }
                        moveScores[i] += getScore(board, counterColour, r, i);// will add the score to the appropiate column.
                        if (depth > 1)
                        {
                            bestMove(depth - 1, convertToString(board), counterColour, oppCounterColour, moveScores, true, i);// if its got more moves to check then recall best move.
                        }
                    }
                    board[r, i] = 0;
                }
            }
            return Array.IndexOf(moveScores, moveScores.Max());// returns the move which in total has the greatest score.
        }

        public int getScore(int[,] board,int counterColour,int row,int col)// will check all the possible directions adjacent counters could be and adds to the total score.
        {
            double score = checkAdjacent(board, counterColour, row, col, 0, 1) + checkAdjacent(board, counterColour, row, col, 1, 0) + checkAdjacent(board, counterColour, row, col, 1, 1) + checkAdjacent(board, counterColour, row, col, -1, 1) + checkAdjacent(board, counterColour, row, col, 1, -1) + checkAdjacent(board,counterColour,row,col,-1,-1);
            return (int)score;
        }
        public double checkAdjacent(int[,] board,int counterNum,int row,int col,int x,int y )
        {
            int count = 0;
            while (row - y >= 0 && row - y < 6 && col - x >= 0 && col - x < 7 && board[row - y, col - x] == counterNum)// will shift to the left as to not miss out on counters if placed in middle.
            {
                row -= y;
                col -= x;
            }
            while (row + y >= 0 && row + y < 6 && col + x >= 0 && col + x < 7 && board[row + y, col + x] == counterNum)//will count across then how many counters of same colour are next to it.
            {
                row += y;
                col += x;
                count++;
            }
            return Math.Pow(count,3);
        }
        public string convertToString(int[,] board)// converts the board to string so can be passed through recursively without changing original.
        {
            string newBoard = "";
            for (int i = 0; i < 6; i++)
			{
			    for (int j = 0; j < 7; j++)
			    {
                    newBoard += board[i, j];
			    }
			}
            return newBoard;
        }
        public int[,] convertToBoard(string board)// Converts the string into a board so can be used within the routine.
        {
            int[,] newBoard = new int[6, 7];
            int count = 0;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    newBoard[i, j] = board[count] - 48; 
                    count ++;
                }
            }
            return newBoard;
        }
    }
}
