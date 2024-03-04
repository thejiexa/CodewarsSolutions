namespace CodewarsSolutions
{
    public class GetLengthOfMissingArrayKata
    {
        public static int? GetLengthOfMissingArray(object[][] arrays) => 
            arrays is null || arrays.Length is 0 || arrays.Any(x => x is null || x.Length is 0) ? 0 : Enumerable.Range(arrays.Min(x => x.Length), arrays.Max(x => x.Length)).FirstOrDefault(x => !arrays.Any(a => a?.Length == x));
    }

    [TestFixture]
    public class GetLengthOfMissingArrayKataTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.That(GetLengthOfMissingArrayKata.GetLengthOfMissingArray(new object[][] { new object[] { 1, 2 }, new object[] { 4, 5, 1, 1 }, new object[] { 1 }, new object[] { 5, 6, 7, 8, 9 } }), Is.EqualTo(3));
            Assert.That(GetLengthOfMissingArrayKata.GetLengthOfMissingArray(new object[][] { new object[] { 5, 2, 9 }, new object[] { 4, 5, 1, 1 }, new object[] { 1 }, new object[] { 5, 6, 7, 8, 9 } }), Is.EqualTo(2));
            Assert.That(GetLengthOfMissingArrayKata.GetLengthOfMissingArray(new object[][] { new object[] { null }, new object[] { null, null, null } }), Is.EqualTo(2));
            Assert.That(GetLengthOfMissingArrayKata.GetLengthOfMissingArray(new object[][] { new object[] { 'a', 'a', 'a' }, new object[] { 'a', 'a' }, new object[] { 'a', 'a', 'a', 'a' }, new object[] { 'a' }, new object[] { 'a', 'a', 'a', 'a', 'a', 'a' } }), Is.EqualTo(5));
            Assert.That(GetLengthOfMissingArrayKata.GetLengthOfMissingArray(new object[][] { }), Is.EqualTo(0));
            Assert.That(GetLengthOfMissingArrayKata.GetLengthOfMissingArray(new object[][] { [], [0, 1, 2, 0, 1, 3], [3, 4, 4], [1, 1, 4, 0, 2], [4, 1, 2, 2, 3, 0, 3], [0, 1, 4, 0, 2, 4, 4, 2, 2], [2, 2, 0, 1, 2, 0, 3, 3, 2, 2], [2], [2, 0], [1, 2, 3, 0, 2, 4, 2, 3] }), Is.EqualTo(0));
            Assert.That(GetLengthOfMissingArrayKata.GetLengthOfMissingArray(new object[][] { [0, 2, 1, 1], [3, 4, 0, 4, 1, 1, 1], [1, 4, 2], [3, 3, 0, 4, 1] }), Is.EqualTo(6));
        }
    }
}