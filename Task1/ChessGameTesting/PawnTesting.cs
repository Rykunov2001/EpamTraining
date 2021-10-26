using NUnit.Framework;
using Figures;
namespace ChessGameTesting
{
    public class PawnTesting
    {
        private Pawn pawn;
        private IChessFigure[,] board;
        private int[] position;
        [SetUp]
        public void Setup()
        {
            pawn = new Pawn("White", 162);
            board = new IChessFigure[8, 8] { { new Rook("White", 111), null, new Bishop("White", 131), new Queen("White", 14), null, new Bishop("White", 132), new Knight("White", 122), new Rook("White", 112)},
                                             { new Pawn("White", 16), new Pawn("White", 162), new Pawn("White", 16), new Pawn("White", 16), new Pawn("White", 16), new Pawn("White", 16), new Pawn("White", 16), new Pawn("White", 16)},
                                             { null,null,null,null,null,null,null,null },
                                             { null,null,null,null,null,null,null,null },
                                             { null,null,null,new Knight("White", 121),null,null,null,null },
                                             { null,null,null,null,null,null,null,null },
                                             { new Pawn("Black", 26), new Pawn("Black", 26), new Pawn("Black", 26), new Pawn("Black", 26), new Pawn("Black", 26), new Pawn("Black", 26), new Pawn("Black", 26), new Pawn("Black", 26)},
                                             { new Rook("Black", 211), new Knight("Black", 221), new Bishop("Black", 231), new Queen("Black", 24), new King("Black", 25), new Bishop("Black", 232), new Knight("Black", 222), new Rook("Black", 212)}
            };
            position = new int[] { 1, 1 };
        }

        [Test]
        public void PawnPosibleMoves_InputIs_1_1_return_0()
        {
            var result = pawn.PosibleMoves(position, board);
            Assert.That(result.Count, Is.EqualTo(2));
        }
    }
}