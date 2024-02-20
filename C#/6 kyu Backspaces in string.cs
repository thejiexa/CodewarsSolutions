namespace CodewarsSolutions
{
    public class CleanStringKata
    {
        public static string CleanString(string s)
        {
            var result = new List<char>();

            s.ToList().ForEach(x => {
                Action action = x switch
                {
                    '#' => () =>
                    {
                        if (result.Count > 0)
                            result.RemoveAt(result.Count - 1);
                    },
                    _ => () => result.Add(x)
                };

                action();
            });

            return string.Join("", result);
        }
    }

    [TestFixture]
    public class CleanStringSolutionTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.That(CleanStringKata.CleanString("abc#d##c"), Is.EqualTo("ac"));
            Assert.That(CleanStringKata.CleanString("abc####d##c#"), Is.EqualTo(""));
        }
    }
}