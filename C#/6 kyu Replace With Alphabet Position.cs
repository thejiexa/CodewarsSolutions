namespace CodewarsSolutions
{
    public static class AlphabetPositionKata
    {
        public static string AlphabetPosition(string text)
        {
            return string
                .Join(" ", text.ToLower()
                .Where("abcdefghijklmnopqrstuvwxyz".Contains)
                .Select(letter => "abcdefghijklmnopqrstuvwxyz".IndexOf(letter) + 1));
        }
    }

    [TestFixture]
    public class AlphabetPositionSolutionTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.That(AlphabetPositionKata.AlphabetPosition("The sunset sets at twelve o' clock."), Is.EqualTo("20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11"));
            Assert.That(AlphabetPositionKata.AlphabetPosition("The narwhal bacons at midnight."), Is.EqualTo("20 8 5 14 1 18 23 8 1 12 2 1 3 15 14 19 1 20 13 9 4 14 9 7 8 20"));
        }
    }
}