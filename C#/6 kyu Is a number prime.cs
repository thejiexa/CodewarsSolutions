namespace CodewarsSolutions
{
    public static class IsPrimeKata
    {
        public static bool IsPrime(int n)
        {
            if (n < 2)
                return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i is 0)
                    return false;
            return true;
        }
    }

    public class IsPrimeTests
    {
        [TestFixture]
        public class SolutionTest
        {
            private static IEnumerable<TestCaseData> sampleTestCases
            {
                get
                {
                    yield return new TestCaseData(0).Returns(false);
                    yield return new TestCaseData(1).Returns(false);
                    yield return new TestCaseData(2).Returns(true);
                }
            }

            [Test, TestCaseSource("sampleTestCases")]
            public bool SampleTest(int n) => IsPrimeKata.IsPrime(n);
        }
    }
}