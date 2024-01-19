namespace CodewarsSolutions
{
    public static class SumCubesKata
    {
        public static long SumCubes(int n) =>
            Enumerable.Range(1, n).Select(i => Convert.ToInt64(Math.Pow(i, 3))).Sum();
    }

    [TestFixture]
    public class SumCubesSolutionTest
    {
        [Test, Description("Sample Tests")]
        public void SampleTest()
        {
            Assert.That(SumCubesKata.SumCubes(1), Is.EqualTo(1));
            Assert.That(SumCubesKata.SumCubes(2), Is.EqualTo(9));
            Assert.That(SumCubesKata.SumCubes(3), Is.EqualTo(36));
            Assert.That(SumCubesKata.SumCubes(4), Is.EqualTo(100));
            Assert.That(SumCubesKata.SumCubes(10), Is.EqualTo(3025));
            Assert.That(SumCubesKata.SumCubes(123), Is.EqualTo(58155876));
        }
    }
}