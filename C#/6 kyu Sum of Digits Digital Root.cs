namespace CodewarsSolutions
{
    public class Number
    {
        public static int DigitalRoot(long n)
        {
            int sum = 0;
            while (n > 0)
            {
                sum += (int)(n % 10);
                n /= 10;
            };
            return sum < 10 ? sum : DigitalRoot(sum);
        }
    }

    [TestFixture]
    public class NumberTest
    {
        [TestCase(0, ExpectedResult = 0)]
        [TestCase(10, ExpectedResult = 1)]
        [TestCase(16, ExpectedResult = 7)]
        [TestCase(195, ExpectedResult = 6)]
        [TestCase(992, ExpectedResult = 2)]
        [TestCase(167346, ExpectedResult = 9)]
        [TestCase(999999999999, ExpectedResult = 9)]
        public int Tests(long n) => Number.DigitalRoot(n);
    }
}