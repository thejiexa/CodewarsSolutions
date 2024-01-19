namespace CodewarsSolutions
{
    public static class WhoLikesIt
    {
        public static string Likes(string[] name) =>
            (name.Length) switch
            {
                0 => "no one likes this",
                1 => $"{name[0]} likes this",
                2 => $"{name[0]} and {name[1]} like this",
                3 => $"{name[0]}, {name[1]} and {name[2]} like this",
                _ => $"{name[0]}, {name[1]} and 2 others like this"
            };
    }

    public class WhoLikesItTests
    {
        [TestFixture]
        public class SolutionTest
        {
            [Test, Description("It should return correct text")]
            public void SampleTest()
            {
                Assert.That(WhoLikesIt.Likes(new string[0]), Is.EqualTo("no one likes this"));
                Assert.That(WhoLikesIt.Likes(new string[] { "Peter" }), Is.EqualTo("Peter likes this"));
                Assert.That(WhoLikesIt.Likes(new string[] { "Jacob", "Alex" }), Is.EqualTo("Jacob and Alex like this"));
                Assert.That(WhoLikesIt.Likes(new string[] { "Max", "John", "Mark" }), Is.EqualTo("Max, John and Mark like this"));
                Assert.That(WhoLikesIt.Likes(new string[] { "Alex", "Jacob", "Mark", "Max" }), Is.EqualTo("Alex, Jacob and 2 others like this"));
            }
        }
    }
}