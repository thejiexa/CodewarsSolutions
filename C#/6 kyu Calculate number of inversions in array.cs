namespace CodewarsSolutions
{
    public class CountInversionsKata
    {
        public static int CountInversions(int[] array) =>
            array.Select((left, i) => array.Skip(i).Count(right => left > right)).Sum();
    }

    [TestFixture]
    public class CountInversionsKataTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.That(CountInversionsKata.CountInversions(new int[] { 1, 2, 3 }), Is.EqualTo(0), "Sorted array has 0 inversions");
            Assert.That(CountInversionsKata.CountInversions(new int[] { 2, 1, 3 }), Is.EqualTo(1), "Array [2,1,3] only has one inversion");
        }
    }
}