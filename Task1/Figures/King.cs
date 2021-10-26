using System;
using System.Collections.Generic;
using System.Text;

namespace Figures
{
    public class King : IChessFigure
    {
        private string color;
        private int id;

        public string GetColor()
        {
            return color;
        }

        public int GetId()
        {
            return id;
        }
        public King(string color, int id)
        {
            this.color = color;
            this.id = id;
        }
        public List<int[]> PosibleMoves(int[] position, IChessFigure[,] board)
        {
            List<int[]> posibleMoves = new List<int[]>();
            for (int i = position[0] - 1 ; i <= position[0] + 1; i++)
            {
                for (int j = position[1] - 1 ; j <= position[1] + 1; j++)
                {
                    if (board[i, j] == null)
                    {
                        posibleMoves.Add(new int[3] { i, j, id });
                        continue;
                    }
                    if (board[i, j].GetColor() != this.GetColor())
                    {
                        posibleMoves.Add(new int[3] { i, j, id });
                    }
                }
            }
            return posibleMoves;
        }
        override public string ToString()
        {
            return GetColor() + "King" + GetId();
        }

        public override bool Equals(object obj)
        {
            return obj is King king &&
                   color == king.color &&
                   id == king.id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(color, id);
        }
    }
}
