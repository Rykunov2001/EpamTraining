using NUnit.Framework;
using Figures;
namespace ChessGameTesting
{
    public class KingTesting
    {
        private King king;
        private IChessFigure[,] board;
        private int[] position;
        [SetUp]
        public void Setup()
        {
            king = new King("White", 15);
            board = new IChessFigure[8, 8] { { new Rook("White", 11), new Knight("White", 12), new Bishop("White", 13), new Queen("White", 14), null, new Bishop("White", 13), new Knight("White", 12), new Rook("White", 11)},
                                             { new Pawn("White", 16), new Pawn("White", 16), new Pawn("White", 16), new Pawn("White", 16), new Pawn("White", 16), new Pawn("White", 16), new Pawn("White", 16), new Pawn("White", 16)},
                                             { null,null,null,null,null,null,null,null },
                                             { null,null,null,null,new King("White", 15),null,null,null },
                                             { null,null,null,null,null,null,null,null },
                                             { null,null,null,null,null,null,null,null },
                                             { new Pawn("Black", 26), new Pawn("Black", 26), new Pawn("Black", 26), new Pawn("Black", 26), new Pawn("Black", 26), new Pawn("Black", 26), new Pawn("Black", 26), new Pawn("Black", 26)},
                                             { new Rook("Black", 21), new Knight("Black", 22), new Bishop("Black", 23), new Queen("Black", 24), new King("Black", 25), new Bishop("Black", 23), new Knight("Black", 22), new Rook("Black", 21)}
            };
            position = new int[] { 3, 4 };
        }

        [Test]
        public void KingPosibleMoves_InputIs_3_4_return_8()
        {
            var result = king.PosibleMoves(position, board);
            Assert.That(result.Count,Is.EqualTo(8));
        }
    }
}