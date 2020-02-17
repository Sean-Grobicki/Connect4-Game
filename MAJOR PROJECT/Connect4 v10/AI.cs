using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Connect4_v10
{
    public class AI : User
    {
        private TreeNode root;
        private int[] moveScores;
        private int depth;


        public AI(int uc)
        {
            _counterColour = uc;
        }

        public int Depth 
        { 
            get => depth; 
            set => depth = value; 
        }

        public int bestMove(int[,] board, int oppCounterColour)
        {
            root = new TreeNode(board,_counterColour,oppCounterColour,Depth); // creates the tree storing moves with the root being the board with no move
            return collectScores();
        }

        public int collectScores()// Called for first layers of branches so can be stored in array.
        {
            moveScores = new int[7];
            TreeNode[] childNodes = root.moves;
            for (int i = 0; i < childNodes.Length; i++)
            {
                if (childNodes[i] != null)
                {
                    if (childNodes[i].checkWin())// Override added to make sure they place to win if they can.
                    {
                        return i;
                    }
                    else
                    {
                        moveScores[i] = childNodes[i].Score + getScores(childNodes[i], false);
                    }
                }
                else
                {
                    moveScores[i] = -120000;
                }
            }
            foreach (int i in moveScores)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();
            return Array.IndexOf(moveScores, moveScores.Max());// returns max in the array of scores meaning it will be optimum score.
        }

        public int getScores(TreeNode node,bool yourMove)// collects the scores recursively 
        {
            int score = 0;
            TreeNode[] childNodes = node.moves;
            for (int i = 0; i < childNodes.Length; i++)
                if (childNodes[i] != null)            {
                {
                    if (yourMove)
                    {
                        score += childNodes[i].Score + getScores(childNodes[i], !yourMove);
                    }
                    else 
                    {
                            if (childNodes[i].checkWin())
                            {

                                if (childNodes[i].PrevCol == i)// prevents the ai from placing to allow 4 in a rows to get blocked.
                                {
                                    return -3000;
                                }
                                else
                                {
                                    return 3000;
                                }

                            }
                            else
                            {
                                score += (-childNodes[i].Score) + getScores(childNodes[i], !yourMove);// recursively calls method so scores for each are added upwards.
                            }
                    }
                }
            }
            return score;
        }

    }
}
