namespace CodewarsSolutions
{
    public class FirstNonRepeatingLetterKata
    {
        public static string FirstNonRepeatingLetter(string s)
        {
            var res = s.GroupBy(char.ToLower).Where(l => l.Count() == 1).FirstOrDefault();
            return res is null ? string.Empty : res.First().ToString();
        }
    }

    [TestFixture]
    public class FirstNonRepeatingLetterKataTest
    {
        [Test]
        public void BasicTests()
        {
            Assert.That(FirstNonRepeatingLetterKata.FirstNonRepeatingLetter("a"), Is.EqualTo("a"));
            Assert.That(FirstNonRepeatingLetterKata.FirstNonRepeatingLetter("stress"), Is.EqualTo("t"));
            Assert.That(FirstNonRepeatingLetterKata.FirstNonRepeatingLetter("moonmen"), Is.EqualTo("e"));
            Assert.That(FirstNonRepeatingLetterKata.FirstNonRepeatingLetter("aabbcc"), Is.EqualTo(string.Empty));
            Assert.That(FirstNonRepeatingLetterKata.FirstNonRepeatingLetter("aABbCc"), Is.EqualTo(string.Empty));
            Assert.That(FirstNonRepeatingLetterKata.FirstNonRepeatingLetter("sTreSS"), Is.EqualTo("T"));
            Assert.That(FirstNonRepeatingLetterKata.FirstNonRepeatingLetter(string.Empty), Is.EqualTo(string.Empty));
        }
    }
}