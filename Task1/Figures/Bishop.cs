using System;
using System.Collections.Generic;

namespace Figures
{
    public class Bishop : IChessFigure
    {
        private string color;
        private int id;

        public Bishop(string color, int id)
        {
            this.color = color;
            this.id = id;
        }
        public string GetColor()
        {
            return color;
        }
        public int GetId()
        {
            return id;
        }
        /// <summary>
        /// method calculating the available moves for a figure
        /// Takes 2 parameters: an array of figure coordinates and checkerboard matrix
        /// </summary>
        /// <param name="position"></param>
        /// <param name="board"></param>
        /// <returns></returns>
        public List<int[]> PosibleMoves(int[] position, IChessFigure[,] board)
        {
            List<int[]> posibleMoves = new List<int[]>();
            int i, j;
            for (i = position[0] + 1, j = position[1] + 1; i <= 7 | j <= 7; i++, j++)
            {
                if (!FigureAdder(board, i, j, ref posibleMoves))
                {
                    break;
                }
            }
            for (i = position[0] - 1, j = position[1] + 1; i >= 0 | j <= 7; i--, j++)
            {
                if (!FigureAdder(board, i, j, ref posibleMoves))
                {
                    break;
                }
            }
            for (i = position[0] + 1, j = position[1] - 1; i <= 7 | j >= 0; i++, j--)
            {
                if (!FigureAdder(board, i, j, ref posibleMoves))
                {
                    break;
                }
            }
            for (i = position[0] - 1, j = position[1] - 1; i >= 0 | j >= 0; i--, j--)
            {
                if (!FigureAdder(board, i, j, ref posibleMoves))
                {
                    break;
                }
            }
            return posibleMoves;
        }
        /// <summary>
        ///  additional method calculating the available moves for a figure
        /// Takes 4 parameters: checkerboard matrix, x,y - positions, list of posibleMoves
        /// </summary>
        /// <param name="board"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="posibleMoves"></param>
        /// <returns></returns>
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
            throw new Exception("Bishop  exception");
        }
        public override bool Equals(object obj)
        {
            return obj is Bishop bishop &&
                   color == bishop.color &&
                   id == bishop.id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(color, id);
        }
        public override string ToString()
        {
            return GetColor() + "Bishop" + GetId();
        }
    }
}
