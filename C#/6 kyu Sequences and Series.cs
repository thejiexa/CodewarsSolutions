namespace CodewarsSolutions
{
    public class Sequence
    {
        public static long GetScore(long n) => Enumerable.Range(1, (int)n).Select(x => (long)x * 50).Sum();
    }

    [TestFixture]
    public class SequenceTest
    {
        [Test]
        public void BasicTests()
        {
            Assert.That(Sequence.GetScore(1), Is.EqualTo(50), "GetScore(1) returns a wrong result");
            Assert.That(Sequence.GetScore(2), Is.EqualTo(150), "GetScore(2) returns a wrong result");
            Assert.That(Sequence.GetScore(3), Is.EqualTo(300), "GetScore(3) returns a wrong result");
            Assert.That(Sequence.GetScore(4), Is.EqualTo(500), "GetScore(4) returns a wrong result");
            Assert.That(Sequence.GetScore(5), Is.EqualTo(750), "GetScore(5) returns a wrong result");
        }
    }
}