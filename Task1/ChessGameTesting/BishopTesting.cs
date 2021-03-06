using NUnit.Framework;
using Figures;
namespace ChessGameTesting
{
    public class BishopTesting
    {
        private Bishop bishop;
        private IChessFigure[,] board;
        private int[] position;
        [SetUp]
        public void Setup()
        {
            bishop = new Bishop("White", 23411);
            board = new IChessFigure[8, 8] { { new Rook("White", 111), null, new Bishop("White", 131),null, null, new Bishop("White", 132), new Knight("White", 122), new Rook("White", 112)},
                                             { new Pawn("White", 16), new Pawn("White", 16), new Pawn("White", 16), new Pawn("White", 16), new Pawn("White", 16), new Pawn("White", 16), new Pawn("White", 16), new Pawn("White", 16)},
                                             { null,null,null,null,null,null,null,null },
                                             { null,null,null,null,null,null,null,null },
                                             { null,null,null, new Bishop("White", 23411),null,null,null,null },
                                             { null,null,null,null,null,null,null,null },
                                             { new Pawn("Black", 26), new Pawn("Black", 26), new Pawn("Black", 26), new Pawn("Black", 26), new Pawn("Black", 26), new Pawn("Black", 26), new Pawn("Black", 26), new Pawn("Black", 26)},
                                             { new Rook("Black", 211), new Knight("Black", 221), new Bishop("Black", 231), new Queen("Black", 24), new King("Black", 25), new Bishop("Black", 232), new Knight("Black", 222), new Rook("Black", 212)}
            };
            position = new int[] { 4, 4 };
        }

        [Test]
        public void BishopPosibleMoves_InputIs_4_4_return_0()
        {
            var result = bishop.PosibleMoves(position, board);
            Assert.That(result.Count, Is.EqualTo(8));
        }
    }
}