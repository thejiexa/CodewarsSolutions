namespace CodewarsSolutions
{
    public class BreakCamelCaseKata
    {
        public static string BreakCamelCase(string str) => string.Concat(str.Select(c => Char.IsUpper(c) ? " " + c : c.ToString()));
    }

    public class BreakCamelCaseTests
    {
        [TestFixture]
        public class Sample_Tests
        {
            private static IEnumerable<TestCaseData> testCases
            {
                get
                {
                    yield return new TestCaseData("camelCasing").Returns("camel Casing");
                    yield return new TestCaseData("camelCasingTest").Returns("camel Casing Test");
                }
            }

            [Test, TestCaseSource("testCases")]
            public string Test(string str) => BreakCamelCaseKata.BreakCamelCase(str);
        }
    }
}