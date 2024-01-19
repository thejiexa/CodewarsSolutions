namespace CodewarsSolutions
{
    public class MexicanWaveKata
    {
        public List<string> wave(string str) =>
            Enumerable.Range(0, str.Length).Select(x => str.Remove(x, 1).Insert(x, char.ToUpper(str[x]).ToString())).Where(c => c.Any(char.IsUpper)).ToList();
    }

    [TestFixture]
    class MexicanWaveKataTest
    {
        [TestCase]
        public void BasicTest1()
        {
            MexicanWaveKata kata = new MexicanWaveKata();
            List<string> result = new List<string> { "Hello", "hEllo", "heLlo", "helLo", "hellO" };
            Assert.That(kata.wave("hello"), Is.EqualTo(result), "it should return '" + result + "'");
        }

        [TestCase]
        public void BasicTest2()
        {
            MexicanWaveKata kata = new MexicanWaveKata();
            List<string> result = new List<string> { "Codewars", "cOdewars", "coDewars", "codEwars", "codeWars", "codewArs", "codewaRs", "codewarS" };
            Assert.That(kata.wave("codewars"), Is.EqualTo(result), "it should return '" + result + "'");
        }

        [TestCase]
        public void BasicTest3()
        {
            MexicanWaveKata kata = new MexicanWaveKata();
            List<string> result = new List<string> { };
            Assert.That(kata.wave(""), Is.EqualTo(result), "it should return '" + result + "'");
        }

        [TestCase]
        public void BasicTest4()
        {
            MexicanWaveKata kata = new MexicanWaveKata();
            List<string> result = new List<string> { "Two words", "tWo words", "twO words", "two Words", "two wOrds", "two woRds", "two worDs", "two wordS" };
            Assert.That(kata.wave("two words"), Is.EqualTo(result), "it should return '" + result + "'");
        }

        [TestCase]
        public void BasicTest5()
        {
            MexicanWaveKata kata = new MexicanWaveKata();
            List<string> result = new List<string> { " Gap ", " gAp ", " gaP " };
            Assert.That(kata.wave(" gap "), Is.EqualTo(result), "it should return '" + result + "'");
        }
    }
}