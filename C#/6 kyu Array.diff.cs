namespace CodewarsSolutions
{
    public class ArrayDiffKata
    {
        public static int[] ArrayDiff(int[] a, int[] b) => Array.FindAll(a, item => !b.Contains(item));
    }

    [TestFixture]
    public class ArrayDiffSolutionTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.That(ArrayDiffKata.ArrayDiff(new int[] { 1, 2 }, new int[] { 1 }), Is.EqualTo(new int[] { 2 }));
            Assert.That(ArrayDiffKata.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 1 }), Is.EqualTo(new int[] { 2, 2 }));
            Assert.That(ArrayDiffKata.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 2 }), Is.EqualTo(new int[] { 1 }));
            Assert.That(ArrayDiffKata.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { }), Is.EqualTo(new int[] { 1, 2, 2 }));
            Assert.That(ArrayDiffKata.ArrayDiff(new int[] { }, new int[] { 1, 2 }), Is.EqualTo(Array.Empty<int>()));
            Assert.That(ArrayDiffKata.ArrayDiff(new int[] { 1, 2, 3 }, new int[] { 1, 2 }), Is.EqualTo(new int[] { 3 }));
        }
    }
}