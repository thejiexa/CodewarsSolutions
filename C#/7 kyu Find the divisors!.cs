namespace CodewarsSolutions
{
    public class DivisorsKata
    {
        public static int[] Divisors(int n)
        {
            int[] res = Enumerable.Range(2, n - 2).Where(x => n % x is 0).ToArray();
            return res.Length > 0 ? res : null;
        }
    }

    [TestFixture]
    public class DivisorsSolutionTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.That(DivisorsKata.Divisors(15), Is.EqualTo(new int[] { 3, 5 }));
            Assert.That(DivisorsKata.Divisors(16), Is.EqualTo(new int[] { 2, 4, 8 }));
            Assert.That(DivisorsKata.Divisors(253), Is.EqualTo(new int[] { 11, 23 }));
            Assert.That(DivisorsKata.Divisors(24), Is.EqualTo(new int[] { 2, 3, 4, 6, 8, 12 }));
            Assert.That(DivisorsKata.Divisors(7), Is.EqualTo(null)); ;
        }
    }
}