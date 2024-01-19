namespace CodewarsSolutions
{
    public class LargestKata
    {
        public static List<int> Largest(int n, List<int> xs) =>
            xs.OrderBy(x => x).TakeLast(n).ToList();
    }

    [TestFixture]
    public class LargestSolutionTest
    {
        [Test, Description("Sample Tests")]
        public void SampleTest()
        {
            Assert.That(LargestKata.Largest(2, new List<int> { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 }), Is.EqualTo(new List<int> { 9, 10 }));
            Assert.That(LargestKata.Largest(3, new List<int> { 5, 1, 5, 2, 3, 1, 2, 3, 5 }), Is.EqualTo(new List<int> { 5, 5, 5 }));
            Assert.That(LargestKata.Largest(7, new List<int> { 9, 1, 50, 22, 3, 13, 2, 63, 5 }), Is.EqualTo(new List<int> { 3, 5, 9, 13, 22, 50, 63 }));
            Assert.That(LargestKata.Largest(0, new List<int> { 1, 2, 3, 4, 8, 7, 6, 5 }), Is.EqualTo(new List<int> { }));
        }
    }
}