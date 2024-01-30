namespace CodewarsSolutions
{
    public class WeightSort
    {
        public static string orderWeight(string strng) =>
            string.Join(" ", strng.Split(' ').OrderBy(x => x.Sum(char.GetNumericValue)).ThenBy(_ => _));
    }

    [TestFixture]
    public class WeightSortTests
    {
        [Test]
        public void Test1()
        {
            Assert.That(WeightSort.orderWeight("103 123 4444 99 2000"), Is.EqualTo("2000 103 123 4444 99"));
            Assert.That(WeightSort.orderWeight("2000 10003 1234000 44444444 9999 11 11 22 123"), Is.EqualTo("11 11 2000 10003 22 123 1234000 44444444 9999"));
        }
    }
}