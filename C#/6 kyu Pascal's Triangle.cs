namespace CodewarsSolutions
{
    public static class PascalsTriangleKata
    {
        public static List<int> PascalsTriangle(int n)
        {
            List<int> Do()
            {
                var res = new List<int>() { 1, 1, 1 };
                int step = 3;

                while (n >= step)
                {
                    res.Add(1);
                    for (int i = 2; i < step; i++)
                        res.Add(res[res.Count() - step] + res[res.Count() - step + 1]);

                    res.Add(1);
                    step++;
                }

                return res;
            };

            return n switch
            {
                1 => new List<int> { 1 },
                2 => new List<int> { 1, 1, 1 },
                _ => Do()
            };

        }
    }

    [TestFixture]
    public class PascalsTriangleTests
    {
        [Test]
        public void Level1()
        {
            CollectionAssert.AreEqual(
                new List<int> { 1 },
                PascalsTriangleKata.PascalsTriangle(1));
        }

        [Test]
        public void Level2()
        {
            CollectionAssert.AreEqual(
                new List<int> { 1, 1, 1 },
                PascalsTriangleKata.PascalsTriangle(2));
        }

        [Test]
        public void Level4()
        {
            CollectionAssert.AreEqual(
                new List<int> { 1, 1, 1, 1, 2, 1, 1, 3, 3, 1 },
                PascalsTriangleKata.PascalsTriangle(4));
        }
    }
}