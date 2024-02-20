namespace CodewarsSolutions
{
    public class SimpleFunBuildPalindromeKata
    {
        public static bool IsPolindrome(string str) => str == string.Concat(str.Reverse());

        public string BuildPalindrome(string str)
        {
            if (IsPolindrome(str))
                return str;

            var tail = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                tail = str[i] + tail;

                if (IsPolindrome(str + tail))
                    return str + tail;
            }

            return str;
        }
    }

    [TestFixture]
    public class SimpleFunBuildPalindromeTest
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFunBuildPalindromeKata();
            Assert.That(kata.BuildPalindrome("abcdc"), Is.EqualTo("abcdcba"));
            Assert.That(kata.BuildPalindrome("ababab"), Is.EqualTo("abababa"));
        }
    }
}