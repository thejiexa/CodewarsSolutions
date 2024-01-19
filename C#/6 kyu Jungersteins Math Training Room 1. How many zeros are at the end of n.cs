namespace CodewarsSolutions
{
    public static class CountZerosKata
    {
        public static int CountZeros(int n)
        {
            if (n % 2 is not 0)
                return 0;

            int prod = 10;
            int res = 0;
            while (prod < n)
            {
                res += n / prod;
                prod *= 5;
            }
            return res;
        }
    }

    public class CountZerosTests
    {
        [TestFixture]
        public class SolutionTest
        {
            private static void Act(int expected, int n) => Assert.That(CountZerosKata.CountZeros(n), Is.EqualTo(expected), $"Input -> n = {n}");

            [Test]
            public void BasicTests()
            {
                Act(0, 8);
                Act(1, 14);
                Act(3, 30);
            }

            [Test]
            public void LargerNumberTests()
            {
                Act(0, 487);
                Act(62, 500);
            }
        }
    }
}