namespace CodewarsSolutions
{
    public static class Multiplesof3or5Kata
    {
        public static int Solution(int value) =>
            value > 2 ? Enumerable.Range(0, value).Where(x => x % 3 == 0 || x % 5 == 0).Sum() : 0;
    }

    [TestFixture]
    public class Multiplesof3or5KataTests
    {
        [Test]
        public void SampleTests()
        {
            Assertion(expected: 23, input: 10);
            Assertion(expected: 78, input: 20);
            Assertion(expected: 9168, input: 200);
            Assertion(expected: 0, input: 0);
        }

        private static void Assertion(int expected, int input) =>
            Assert.That(Multiplesof3or5Kata.Solution(input), Is.EqualTo(expected), $"Value: {input}");
    }
}