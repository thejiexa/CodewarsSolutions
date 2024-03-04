namespace CodewarsSolutions
{
    public class IsAltKata
    {
        public static bool IsAlt(string word) => word.Select((letter, index) => index % 2 == 0 ? "aeiou".Contains(letter) : !"aeiou".Contains(letter)).Distinct().Count() is 1;
    }

    [TestFixture]
    public class IsAltTest
    {
        [Test]
        public void BasicTests()
        {
            Assert.That(IsAltKata.IsAlt("amazon"), Is.EqualTo(true));
            Assert.That(IsAltKata.IsAlt("apple"), Is.EqualTo(false));
            Assert.That(IsAltKata.IsAlt("banana"), Is.EqualTo(true));
        }
    }
}