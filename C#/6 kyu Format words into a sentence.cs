namespace CodewarsSolutions
{
    public static class FormatWordsKata
    {
        public static string FormatWords(string[] words)
        {
            if (words is null) return string.Empty;
            var list = words.Where(x => x is not "").ToList();
            return list.Count switch
            {
                0 => string.Empty,
                1 => list.First(),
                _ => $"{string.Join(", ", list.Take(list.Count - 1))} and {list.Last()}"
            };
        }
    }

    [TestFixture]
    public class FormatWordsTests
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData(new[] { new string[] { "one", "two", "three", "four" } })
                                    .Returns("one, two, three and four")
                                    .SetDescription("{\"one\", \"two\", \"three\", \"four\"} should return \"one, two, three and four\"");
                yield return new TestCaseData(new[] { new string[] { "one" } })
                                    .Returns("one")
                                    .SetDescription("{\"one\"} should return \"one\"");
                yield return new TestCaseData(new[] { new string[] { "one", "", "three" } })
                                    .Returns("one and three")
                                    .SetDescription("{\"one\", \"\", \"three\"} should return \"one and three\"");
                yield return new TestCaseData(new[] { new string[] { "", "", "three" } })
                                    .Returns("three")
                                    .SetDescription("{\"\", \"\", \"three\"} should return \"three\"");
                yield return new TestCaseData(new[] { new string[] { "one", "two", "" } })
                                    .Returns("one and two")
                                    .SetDescription("{\"one\", \"two\", \"\"} should return \"one and two\"");
                yield return new TestCaseData(new[] { new string[] { } })
                                    .Returns("")
                                    .SetDescription("{} should return \"\"");
                yield return new TestCaseData(null)
                                    .Returns("")
                                    .SetDescription("null should return \"\"");
                yield return new TestCaseData(new[] { new string[] { "" } })
                                    .Returns("")
                                    .SetDescription("{\"\"} should return \"\"");
            }
        }

        [Test, TestCaseSource("testCases")]
        public string Test(string[] words) => FormatWordsKata.FormatWords(words);
    }
}