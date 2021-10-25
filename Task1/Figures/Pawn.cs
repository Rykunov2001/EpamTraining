using System;
using System.Collections.Generic;
using System.Text;

namespace Figures
{
    public class Pawn : IChessFigure
    {
        private string color;
        private int id;
        private bool isMoved;

        public Pawn(string color, int id)
        {
            this.color = color;
            this.id = id;
            isMoved = false;
        }
        public int GetId()
        {
            return id;
        }
        public string GetColor()
        {
            return color;
        }
        public List<int[]> PosibleMoves(int[] position, IChessFigure[,] board)
        {
            List<int[]> posibleMoves = new List<int[]>();
            int[] j;
            if (this.GetColor() == "White")
            {
                j = new int[] { position[1] + 1, position[1] + 2 };
            }
            else
            {
                j = new int[] { position[1] - 1, position[1] - 2 };
            }
            if (FigureAdder(board, position[0], j[0], ref posibleMoves) && !isMoved)
            {
                FigureAdder(board, position[0], j[1], ref posibleMoves);
            }
            if (board[position[0] - 1, j[0]].GetColor() != this.GetColor())
            {
                posibleMoves.Add(new int[3] { position[0] - 1, j[0], id });
            }
            if (board[position[0] + 1, j[0]].GetColor() != this.GetColor())
            {
                posibleMoves.Add(new int[3] { position[0] + 1, j[0], id });
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
            throw new Exception("Pawn exception");
        }
        public override string ToString()
        {   
            return GetColor() + "Pawn"  + GetId();
        }
        public override bool Equals(object obj)
        {
            return obj is Pawn pawn &&
                   color == pawn.color &&
                   id == pawn.id &&
                   isMoved == pawn.isMoved;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(color, id, isMoved);
        }
    }
}
