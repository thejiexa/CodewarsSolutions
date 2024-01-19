namespace CodewarsSolutions
{
    public class SpiralingBox
    {
        public static int[,] CreateBox(int m, int n)
        {
            int[,] res = new int[n, m];

            for (var i = 0; i < n; i++)
                for (var j = 0; j < m; j++)
                    res[i, j] = new int[] { i + 1, j + 1, m - j, n - i }.Min();

            return res;
        }
    }

    public class SpiralingBoxTests
    {
        [TestFixture]
        public class SolutionTest
        {
            [Test]
            public void sampleTests()
            {
                int[,] box_7_8 = {{1, 1, 1, 1, 1, 1, 1},
                            {1, 2, 2, 2, 2, 2, 1},
                            {1, 2, 3, 3, 3, 2, 1},
                            {1, 2, 3, 4, 3, 2, 1},
                            {1, 2, 3, 4, 3, 2, 1},
                            {1, 2, 3, 3, 3, 2, 1},
                            {1, 2, 2, 2, 2, 2, 1},
                            {1, 1, 1, 1, 1, 1, 1}};

                int[,] box_8_7 = {{1, 1, 1, 1, 1, 1, 1, 1},
                            {1, 2, 2, 2, 2, 2, 2, 1},
                            {1, 2, 3, 3, 3, 3, 2, 1},
                            {1, 2, 3, 4, 4, 3, 2, 1},
                            {1, 2, 3, 3, 3, 3, 2, 1},
                            {1, 2, 2, 2, 2, 2, 2, 1},
                            {1, 1, 1, 1, 1, 1, 1, 1}};

                int[,] box_4_2 = { { 1, 1, 1, 1 }, { 1, 1, 1, 1 } };

                int[,] box_2_4 = { { 1, 1 }, { 1, 1 }, { 1, 1 }, { 1, 1 } };

                CollectionAssert.AreEqual(box_7_8, SpiralingBox.CreateBox(7, 8));

                CollectionAssert.AreEqual(box_8_7, SpiralingBox.CreateBox(8, 7));

                CollectionAssert.AreEqual(box_4_2, SpiralingBox.CreateBox(4, 2));

                CollectionAssert.AreEqual(box_2_4, SpiralingBox.CreateBox(2, 4));
            }
        }
    }
}