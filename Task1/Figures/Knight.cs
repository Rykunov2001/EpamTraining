using System;
using System.Collections.Generic;
using System.Text;

namespace Figures
{
    class Knight : IChessFigure
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

        public Knight(string color, int id)
        {
            this.color = color;
            this.id = id;
        }
        public List<int[]> PosibleMoves(int[] position, IChessFigure[,] board)
        {
            List<int[]> posibleMoves = new List<int[]>();
            int[] i = new int[] { -2, -2, -1, -1, +1, +1, +2, +2 };
            int[] j = new int[] { -1, +1, -2, +2, -2, +2, -1, +1 };
            for (int k = 0; k < i.Length - 1; k++)
            {
                if (position[0] + i[k] < 0 | position[1] + j[k] < 0 | position[0] + i[k] > 7 | position[1] + j[k] > 7)
                {
                    continue;
                }
                if (board[position[0] + i[k], position[1] + j[k]] == null)
                {
                    posibleMoves.Add(new int[3] { position[0] + i[k], position[1] + j[k], id });
                    continue;
                }
                if (board[position[0] + i[k], position[1] + j[k]].GetColor() != this.GetColor())
                {
                    posibleMoves.Add(new int[3] { position[0] + i[k], position[1] + j[k], id });
                }
            }
            return posibleMoves;
        }
        public override string ToString()
        {
            return "Knight";
        }

        public override bool Equals(object obj)
        {
            return obj is Knight knight &&
                   color == knight.color &&
                   id == knight.id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(color, id);
        }
    }
}
