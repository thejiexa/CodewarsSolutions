namespace CodewarsSolutions
{
    public class IsValidWalkKata
    {
        public static bool IsValidWalk(string[] walk) =>
            walk.Length is 10 && walk.Count(x => x is "n") == walk.Count(x => x is "s") && walk.Count(x => x is "w") == walk.Count(x => x is "e");
    }

    [TestFixture]
    public class IsValidWalkSolutionTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.That(IsValidWalkKata.IsValidWalk(new string[] { "n", "s", "n", "s", "n", "s", "n", "s", "n", "s" }), Is.EqualTo(true), "should return true");
            Assert.That(IsValidWalkKata.IsValidWalk(new string[] { "w", "e", "w", "e", "w", "e", "w", "e", "w", "e", "w", "e" }), Is.EqualTo(false), "should return false");
            Assert.That(IsValidWalkKata.IsValidWalk(new string[] { "w" }), Is.EqualTo(false), "should return false");
            Assert.That(IsValidWalkKata.IsValidWalk(new string[] { "n", "n", "n", "s", "n", "s", "n", "s", "n", "s" }), Is.EqualTo(false), "should return false");
        }
    }
}