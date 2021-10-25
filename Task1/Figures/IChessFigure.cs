using System;
using System.Collections.Generic;
using System.Text;

namespace Figures
{
    public interface IChessFigure
    {
        string GetColor();
        int GetId();
        List<int[]> PosibleMoves(int[] position, IChessFigure[,] board);
        string ToString();
        bool Equals(object obj);
        int GetHashCode();

    }
}
