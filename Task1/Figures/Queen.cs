using System;
using System.Collections.Generic;
using System.Text;

namespace Figures
{
    public class Queen : IChessFigure
    {
        private string color;
        private int id;
        private Bishop bishop;
        private Rook rook;

        public string GetColor()
        {
            return color;
        }

        public int GetId()
        {
            return id;
        }
        public Queen(string color, int id)
        {
            this.color = color;
            this.id = id;
            bishop = new Bishop(color, id);
            rook = new Rook(color, id);
        }   
        public List<int[]> PosibleMoves(int[] position, IChessFigure[,] board)
        {
            List<int[]> posibleMoves = new List<int[]>();
            posibleMoves.AddRange(rook.PosibleMoves(position, board));
            posibleMoves.AddRange(bishop.PosibleMoves(position, board));
            return posibleMoves;
        }
        public override string ToString()
        {
            return GetColor() + "Queen" + GetId();
        }

        public override bool Equals(object obj)
        {
            return obj is Queen queen &&
                   color == queen.color &&
                   id == queen.id &&
                   EqualityComparer<Bishop>.Default.Equals(bishop, queen.bishop) &&
                   EqualityComparer<Rook>.Default.Equals(rook, queen.rook);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(color, id, bishop, rook);
        }
    }
}

