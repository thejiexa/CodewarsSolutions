namespace CodewarsSolutions
{
    public class DuplicateEncodeKata
    {
        public static string DuplicateEncode(string word) =>
            string.Concat(word.ToLower().Select(x => word.ToLower().Count(c => c == x) is 1 ? '(' : ')'));
    }

    [TestFixture]
    public class DuplicateEncodeKataTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.That(DuplicateEncodeKata.DuplicateEncode("din"), Is.EqualTo("((("));
            Assert.That(DuplicateEncodeKata.DuplicateEncode("recede"), Is.EqualTo("()()()"));
            Assert.That(DuplicateEncodeKata.DuplicateEncode("Success"), Is.EqualTo(")())())"), "should ignore case");
            Assert.That(DuplicateEncodeKata.DuplicateEncode("(( @"), Is.EqualTo("))(("));
        }
    }
}