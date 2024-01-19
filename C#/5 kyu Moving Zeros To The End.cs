namespace CodewarsSolutions
{
    public class MoveZeroesKata
    {
        public static int[] MoveZeroes(int[] arr) => arr.OrderBy(x => x is 0).ToArray();
    }

    [TestFixture]
    public class MoveZeroesTest
    {
        [Test]
        public void Test() => Assert.That(MoveZeroesKata.MoveZeroes(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 }), Is.EqualTo(new int[] { 1, 2, 1, 1, 3, 1, 0, 0, 0, 0 }));
    }
}