namespace CodewarsSolutions
{
    public class NarcissisticKata
    {
        public static bool Narcissistic(int value) =>
            value.ToString().Sum(x => Math.Pow(char.GetNumericValue(x), value.ToString().Length)) == value;
    }

    [TestFixture]
    public class NarcissisticSample_Test
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData(1)
                                .Returns(true)
                                .SetDescription("1 is narcissitic");
                yield return new TestCaseData(371)
                                .Returns(true)
                                .SetDescription("371 is narcissitic");
            }
        }

        [Test, TestCaseSource("testCases")]
        public bool Test(int n) => NarcissisticKata.Narcissistic(n);
    }
}