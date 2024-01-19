namespace CodewarsSolutions
{
    class FindItKata
    {
        public static int find_it(int[] seq) => seq.First(x => seq.Count(i => i == x) % 2 is 1);
    }

    public class FindItTests
    {
        [TestFixture]
        public class SolutionTest
        {
            [Test]
            public void Tests() => Assert.That(FindItKata.find_it(new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 }), Is.EqualTo(5));
        }
    }
}