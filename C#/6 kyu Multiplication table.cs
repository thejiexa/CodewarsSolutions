namespace CodewarsSolutions
{
    class MultiplicationTableKata
    {
        public static int[,] MultiplicationTable(int size)
        {
            int[,] res = new int[size, size];

            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    res[i, j] = (j + 1) * (i + 1);

            return res;
        }
    }

    public class MultiplicationTableTests
    {
        [TestFixture]
        public class SolutionTest
        {
            [Test]
            public void MyTest()
            {
                int[,] expected = new int[,] { { 1, 2, 3 }, { 2, 4, 6 }, { 3, 6, 9 } };
                Assert.That(MultiplicationTableKata.MultiplicationTable(3), Is.EqualTo(expected));
            }
        }
    }
}