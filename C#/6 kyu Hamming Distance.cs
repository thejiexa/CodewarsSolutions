namespace CodewarsSolutions
{
    public class Hamming
    {
        public static int Distance(string a, string b) =>
            a.Where((item, i) => item != b[i]).Count();
    }

    [TestFixture]
    public class HammingTests
    {
        [TestCase("hello world", "hello world", 0)]
        [TestCase("I like turtles", "I like turkeys", 3)]
        public void StaticTests(string a, string b, int expected)
        {
            Assert.That(Hamming.Distance(a, b), Is.EqualTo(expected),
            string.Format("Expected hamming distance of '{0}' and '{1}' to be {2}", a, b, expected));
        }
    }
}