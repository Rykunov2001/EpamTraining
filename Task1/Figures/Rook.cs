using System;
using System.Collections.Generic;
using System.Text;

namespace Figures
{
    public class Rook : IChessFigure
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

        public Rook(string color, int id)
        {
            this.color = color;
            this.id = id;
        }
        public List<int[]> PosibleMoves(int[] position, IChessFigure[,] board)
        {
            List<int[]> posibleMoves = new List<int[]>();
            for (int i = position[0] + 1; i <= 7; i++)
            {
                if (!FigureAdder(board, i, position[1], ref posibleMoves))
                {
                    break;
                }
            }
            for (int i = position[0] - 1; i >= 0; i--)
            {
                if (!FigureAdder(board, i, position[1], ref posibleMoves))
                {
                    break;
                }
            }
            for (int i = position[1] + 1; i <= 7; i++)
            {
                if (!FigureAdder(board, position[0], i, ref posibleMoves))
                {
                    break;
                }
            }
            for (int i = position[1] - 1; i >= 0; i--)
            {
                if (!FigureAdder(board, position[0], i, ref posibleMoves))
                {
                    break;
                }
            }
            return posibleMoves;
        }

        private bool FigureAdder(IChessFigure[,] board, int x, int y, ref List<int[]> posibleMoves)
        {
            if (board[x, y] == null)
            {
                posibleMoves.Add(new int[3] { x, y, id });
                return true;
            }
            if (board[x, y].GetColor() != this.GetColor())
            {
                posibleMoves.Add(new int[3] { x, y, id });
                return false;
            }
            if (board[x, y].GetColor() == this.GetColor())
            {
                return false;
            }
            throw new Exception("Rook exception");
        }

        public override string ToString()
        {
            return GetColor() + "Rook" + GetId();
        }

        public override bool Equals(object obj)
        {
            return obj is Rook rook &&
                   color == rook.color &&
                   id == rook.id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(color, id);
        }
    }
}
