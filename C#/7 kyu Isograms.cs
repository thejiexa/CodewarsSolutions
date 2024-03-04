namespace CodewarsSolutions
{
    public class IsIsogramKata
    {
        public static bool IsIsogram(string str) => str.Length == str.ToLower().ToHashSet().Count;

        [TestFixture]
        public class IsIsogramTests
        {
            private static IEnumerable<TestCaseData> testCases
            {
                get
                {
                    yield return new TestCaseData("Dermatoglyphics").Returns(true);
                    yield return new TestCaseData("isogram").Returns(true);
                    yield return new TestCaseData("moose").Returns(false);
                    yield return new TestCaseData("isIsogram").Returns(false);
                    yield return new TestCaseData("aba").Returns(false);
                    yield return new TestCaseData("moOse").Returns(false);
                    yield return new TestCaseData("thumbscrewjapingly").Returns(true);
                    yield return new TestCaseData("").Returns(true);
                }
            }

            [Test, TestCaseSource("testCases")]
            public bool Test(string str) => IsIsogramKata.IsIsogram(str);
        }
    }
}