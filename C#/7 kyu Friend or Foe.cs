namespace CodewarsSolutions
{
    public static class FriendOrFoeKata
    {
        public static IEnumerable<string> FriendOrFoe(string[] names) =>
            names.Where(x => x.Length is 4);
    }

    [TestFixture]
    public class FriendOrFoeKataTests
    {
        [Test]
        public void Test1()
        {
            string[] expected = { "Ryan", "Mark" };
            string[] names = { "Ryan", "Kieran", "Mark", "Jimmy" };
            CollectionAssert.AreEqual(expected, FriendOrFoeKata.FriendOrFoe(names));
        }
    }
}