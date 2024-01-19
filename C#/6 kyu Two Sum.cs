namespace CodewarsSolutions
{
    public class TwoSumKata
    {
        public static int[] TwoSum(int[] numbers, int target)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
                for (int j = i + 1; j < numbers.Length; j++)
                    if (i != j && numbers[i] + numbers[j] == target)
                        return new int[] { j, i };

            return new int[0];
        }
    }

    [TestFixture]
    public class TwoSumKataTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.That(TwoSumKata.TwoSum(new[] { 1, 2, 3 }, 4).OrderBy(a => a).ToArray(), Is.EqualTo(new[] { 0, 2 }));
            Assert.That(TwoSumKata.TwoSum(new[] { 1234, 5678, 9012 }, 14690).OrderBy(a => a).ToArray(), Is.EqualTo(new[] { 1, 2 }));
            Assert.That(TwoSumKata.TwoSum(new[] { 2, 2, 3 }, 4).OrderBy(a => a).ToArray(), Is.EqualTo(new[] { 0, 1 }));
        }
    }
}