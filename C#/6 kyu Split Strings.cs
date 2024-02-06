namespace CodewarsSolutions
{
    public class SplitString
    {
        public static string[] Solution(string str)
        {
            str = str.Length % 2 is 0 ? str : str + "_";
            return Enumerable.Range(0, str.Length / 2).Select(i => str.Substring(i * 2, 2)).ToArray();
        }
    }

    [TestFixture]
    public class SplitStringTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.That(SplitString.Solution("abc"), Is.EqualTo(new string[] { "ab", "c_" }));
            Assert.That(SplitString.Solution("abcdef"), Is.EqualTo(new string[] { "ab", "cd", "ef" }));
        }
    }
}