namespace CodewarsSolutions
{
    public class CountBitsKata
    {
        public static int CountBits(int n) => Convert.ToString(n, 2).Count(x => x is '1');
    }

    [TestFixture]
    public class BitCountingTest
    {
        [Test]
        public void CountBits()
        {
            Assert.That(CountBitsKata.CountBits(0), Is.EqualTo(0));
            Assert.That(CountBitsKata.CountBits(4), Is.EqualTo(1));
            Assert.That(CountBitsKata.CountBits(7), Is.EqualTo(3));
            Assert.That(CountBitsKata.CountBits(9), Is.EqualTo(2));
            Assert.That(CountBitsKata.CountBits(10), Is.EqualTo(2));
        }
    }
}