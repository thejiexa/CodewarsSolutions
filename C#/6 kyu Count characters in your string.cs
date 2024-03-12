namespace CodewarsSolutions
{
    public class CountCharactersKata
    {
        public static Dictionary<char, int> Count(string str) => str.GroupBy(_ => _).ToDictionary(x => x.Key, x => x.Count()); 
    }

    [TestFixture]
    public class CountCharactersTests
    {
        private static void Tester(Dictionary<char, int> expected, Dictionary<char, int> submitted, string input)
        {
            foreach (KeyValuePair<char, int> entry in expected)
            {
                char key = entry.Key;
                if (submitted.ContainsKey(key))
                {
                    int val = entry.Value;
                    int num = submitted[key];
                    if (num != val)
                    {
                        Assert.AreEqual(val, num, $"For input string: \"{input}\"\n \n< Incorrect Value for Key '{key}' >");
                    }
                }
                else
                {
                    Assert.AreEqual(true, false, $"For input string: \"{input}\"\n \n< The submitted Dictionary should contain an entry for key '{entry.Key}' >");
                }
            }
            foreach (KeyValuePair<char, int> entry in submitted)
            {
                if (expected.ContainsKey(entry.Key) == false)
                {
                    Assert.AreEqual(false, true, $"For input string: \"{input}\"\n \n< The submitted Dictionary should NOT contain an entry for key '{entry.Key}' >");
                }
            }
            Assert.AreEqual(true, true);
        }
        [Test]
        public static void SampleTest_a()
        {
            Dictionary<char, int> d = new Dictionary<char, int>();
            d.Add('a', 1);
            string s = "a";
            Tester(d, CountCharactersKata.Count(s), s);
        }
        [Test]
        public static void SampleTest_aba()
        {
            Dictionary<char, int> d = new Dictionary<char, int>();
            d.Add('a', 2);
            d.Add('b', 1);
            string s = "aba";
            Tester(d, CountCharactersKata.Count(s), s);
        }
    }
}