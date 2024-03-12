namespace CodewarsSolutions
{
    static class ArrayHelpersExtensions
    {
        public static int[] Square(this int[] array) => array.Select(x => x * x).ToArray();
        public static int[] Cube(this int[] array) => array.Select(x => x * x * x).ToArray();
        public static double Average(this int[] array) => array.Length > 0 ? array.Sum(x => x) / array.Length : double.NaN;
        public static int Sum(this int[] array) => array.Sum(x => x);
        public static int[] Even(this int[] array) => array.Where(x => x % 2 == 0).ToArray();
        public static int[] Odd(this int[] array) => array.Where(x => x % 2 != 0).ToArray();
    }

    [TestFixture]
    public class ArrayHelpersExtensionsTests
    {
        int[] array = new[] { 1, 2, 3, 4, 5 };

        [Test]
        public void ShouldSquareCorrectly()
        {
            CollectionAssert.AreEqual(new[] { 1, 4, 9, 16, 25 }, array.Square(), "Square should work correctly");
            CollectionAssert.AreEqual(new[] { 1, 2, 3, 4, 5 }, array, "Original array should not be modified");
            Assert.IsTrue(array.Square() is int[], "Square should return an array");
        }

        [Test]
        public void ShouldCubeCorrectly()
        {
            CollectionAssert.AreEqual(new[] { 1, 8, 27, 64, 125 }, array.Cube(), "Cube should work correctly");
            CollectionAssert.AreEqual(new[] { 1, 2, 3, 4, 5 }, array, "Original array should not be modified");
            Assert.IsTrue(array.Cube() is int[], "Cube should return an array");
        }

        [Test]
        public void ShouldSumCorrectly()
        {
            Assert.That(array.Sum(), Is.EqualTo(15), "Sum should work correctly");
            CollectionAssert.AreEqual(new[] { 1, 2, 3, 4, 5 }, array, "Original array should not be modified");
        }

        [Test]
        public void ShouldAverageCorrectly()
        {
            Assert.That(array.Average(), Is.EqualTo(3), "Average should work correctly");
            CollectionAssert.AreEqual(new[] { 1, 2, 3, 4, 5 }, array, "Original array should not be modified");
        }

        [Test]
        public void ShouldEvenAndOddCorrectly()
        {
            CollectionAssert.AreEqual(new[] { 2, 4 }, array.Even(), "Even should work correctly");
            CollectionAssert.AreEqual(new[] { 1, 2, 3, 4, 5 }, array, "Original array should not be modified");
            Assert.IsTrue(array.Even() is int[], "Even should return an array");

            CollectionAssert.AreEqual(new[] { 1, 3, 5 }, array.Odd(), "Odd should work correctly");
            CollectionAssert.AreEqual(new[] { 1, 2, 3, 4, 5 }, array, "Original array should not be modified");
            Assert.IsTrue(array.Odd() is int[], "Odd should return an array");
        }
    }
}