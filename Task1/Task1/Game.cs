using System;
using System.Collections.Generic;
using Figures;
using Logging;
namespace Task1
{
    
    public class Game
    {
        private List<string> movesList;
        private IChessFigure[,] board;
        private bool whiteTurn;
        /// <summary>
        /// method puts chess figures on the board
        /// </summary>
        public void InitialiseBoard()
        {
            board = new IChessFigure[8, 8] { { new Rook("White", 11), new Knight("White", 12), new Bishop("White", 13), new Queen("White", 14), new King("White", 15), new Bishop("White", 13), new Knight("White", 12), new Rook("White", 11)},
                                             { new Pawn("White", 16), new Pawn("White", 16), new Pawn("White", 16), new Pawn("White", 16), new Pawn("White", 16), new Pawn("White", 16), new Pawn("White", 16), new Pawn("White", 16)},
                                             { null,null,null,null,null,null,null,null },
                                             { null,null,null,null,null,null,null,null },
                                             { null,null,null,null,null,null,null,null },
                                             { null,null,null,null,null,null,null,null },
                                             { new Pawn("Black", 26), new Pawn("Black", 26), new Pawn("Black", 26), new Pawn("Black", 26), new Pawn("Black", 26), new Pawn("Black", 26), new Pawn("Black", 26), new Pawn("Black", 26)},
                                             { new Rook("Black", 21), new Knight("Black", 22), new Bishop("Black", 23), new Queen("Black", 24), new King("Black", 25), new Bishop("Black", 23), new Knight("Black", 22), new Rook("Black", 21)}
            };
        }
        /// <summary>
        /// method making the move of the selected figures 
        /// Takes 2 parameters: checkerboard matrix and array of move's coordinates
        /// </summary>
        /// <param name="board"></param>
        /// <param name="move"></param>
        /// <returns></returns>
        private IChessFigure[,] MakeMove(IChessFigure[,] board, int[] move)
        {
            IChessFigure[,] boardAfterMove = board;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (board[i, j].GetId() == move[2])
                    {
                        board[move[0], move[1]] = board[i, j];
                        board[i, j] = null;
                        return board;
                    }
                }
            }
            throw new Exception("MakeMove exception.");
        }




    }
}
