namespace CodewarsSolutions
{
    public class FindMissingKata
    {
        public static int FindMissing(List<int> list)
        {
            int difference = (list.Last() - list.First()) / list.Count;
            int missing = list.Zip(list.Skip(1), (a, b) => (a, b)).FirstOrDefault(pair => pair.b - pair.a != difference).a + difference;
            return missing;
        }
    }

    [TestFixture]
    public class FindMissingTest
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData(new[] { new List<int> { 1, 3, 5, 9, 11 } }).Returns(7);
                yield return new TestCaseData(new[] { new List<int> { 0, 5, 10, 20, 25 } }).Returns(15);
                yield return new TestCaseData(new[] { new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 11 } }).Returns(10);
                yield return new TestCaseData(new[] { new List<int> { 1040, 1220, 1580 } }).Returns(1400);
            }
        }

        [Test, TestCaseSource("testCases")]
        public int Test(List<int> list) => FindMissingKata.FindMissing(list);
    }
}