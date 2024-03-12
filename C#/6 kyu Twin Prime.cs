namespace CodewarsSolutions
{
    public static class IsTwinPrimeKata
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

        public static bool IsTwinPrime(int n) => IsPrime(n) && (IsTwinPrime(n - 2) || IsPrime(n + 2));
    }

    [TestFixture]
    public class IsTwinPrimeSolutionTest
    {
        private static Tuple<bool, int>[] testCases = new Tuple<bool, int>[]
        {
            Tuple.Create(true, 5),
            Tuple.Create(false, 25)
        };

        [Test, TestCaseSource("testCases")]
        public void SampleTest(Tuple<bool, int> t) => 
            Assert.That(IsTwinPrimeKata.IsTwinPrime(t.Item2), Is.EqualTo(t.Item1));
    }
}