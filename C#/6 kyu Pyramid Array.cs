namespace CodewarsSolutions
{
    public class PyramidKata
    {
        public static int[][] Pyramid(int n) =>
            Enumerable.Range(1, n).Select(x => Enumerable.Repeat(1, x).ToArray()).ToArray();
    }

    [TestFixture]
    public class PyramidSolutionTest
    {
        [Test]
        public void BasicTests()
        {
            Assert.That(PyramidKata.Pyramid(0), Is.EqualTo(new int[][] { }));
            Assert.That(PyramidKata.Pyramid(1), Is.EqualTo(new int[][] { new int[] { 1 } }));
            Assert.That(PyramidKata.Pyramid(2), Is.EqualTo(new int[][] { new int[] { 1 }, new int[] { 1, 1 } }));
            Assert.That(PyramidKata.Pyramid(3), Is.EqualTo(new int[][] { new int[] { 1 }, new int[] { 1, 1 }, new int[] { 1, 1, 1 } }));
        }
    }
}