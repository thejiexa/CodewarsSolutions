namespace CodewarsSolutions
{
    public class TicTacToe
    {
        public int IsSolved(int[,] board)
        {
            int zeros = 0;
            for (int i = 0; i < board.GetLength(0); i++)
            {
                int rowX = 0;
                int colX = 0;
                int rowO = 0;
                int colO = 0;
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] == 1) rowX++;
                    if (board[j, i] == 1) colX++;
                    if (board[i, j] == 2) rowO++;
                    if (board[j, i] == 2) colO++;
                    if (board[i, j] == 0) zeros++;
                }

                if (rowX == 3 || colX == 3) return 1;
                if (rowO == 3 || colO == 3) return 2;
            }

            int diagonal1X = 0;
            int diagonal2X = 0;
            int diagonal1O = 0;
            int diagonal2O = 0;

            for (int i = 0; i < board.GetLength(0); i++)
            {
                if (board[i, i] == 1) diagonal1X++;
                if (board[i, board.GetLength(1) - i - 1] == 1) diagonal2X++;

                if (board[i, i] == 2) diagonal1O++;
                if (board[i, board.GetLength(1) - i - 1] == 2) diagonal2O++;

                if (diagonal1X == 3 || diagonal2X == 3) return 1;
                if (diagonal1O == 3 || diagonal2O == 3) return 2;

            }

            return zeros is 0 ? 0 : -1;
        }
    }

    [TestFixture]
    public class TicTacToeTest
    {
        private TicTacToe tictactoe = new TicTacToe();

        [Test]
        public void test1()
        {
            int[,] board = new int[,] { { 1, 1, 1 }, { 0, 2, 2 }, { 0, 0, 0 } };
            Assert.That(tictactoe.IsSolved(board), Is.EqualTo(1));
        }
    }
}