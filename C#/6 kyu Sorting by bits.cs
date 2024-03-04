namespace CodewarsSolutions
{
    class SortByBitKata
    {
        public static int[] SortByBit(int[] array) => array.OrderBy(x => Convert.ToString(x, 2).Count(x => x is '1')).ThenBy(_ => _).ToArray();
    }

    [TestFixture]
    class SortByBitTests
    {
        [Test]
        [TestCase(new[] { 3, 8, 3, 6, 5, 7, 9, 1 }, new[] { 1, 8, 3, 3, 5, 6, 9, 7 })]
        [TestCase(new[] { 9, 4, 5, 3, 5, 7, 2, 56, 8, 2, 6, 8, 0 }, new[] { 0, 2, 2, 4, 8, 8, 3, 5, 5, 6, 9, 7, 56 })]
        public void BasicTests(int[] input, int[] expected)
        {
            Assert.That(SortByBitKata.SortByBit(input), Is.EqualTo(expected));
        }
    }
}