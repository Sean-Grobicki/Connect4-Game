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
            root = new TreeNode(board,_counterColour,oppCounterColour,Depth);
            collectScores();
            foreach (int i in moveScores)
            {
                Console.Write(i+", ");
            }
            Console.WriteLine("");
            return Array.IndexOf(moveScores, moveScores.Max());
        }

        public void collectScores()
        {
            moveScores = new int[7];
            TreeNode[] childNodes = root.moves;
            for (int i = 0; i < childNodes.Length; i++)
            {
                if (childNodes[i] != null)
                {
                    if (childNodes[i].checkWin())
                    {
                        moveScores[i] = 5000;
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
        }

        public int getScores(TreeNode node,bool yourMove)
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
                            score -= 3000;
                        }
                       score += (-childNodes[i].Score) + getScores(childNodes[i], !yourMove);
                    }
                }
            }
            return score;
        }

    }
}
