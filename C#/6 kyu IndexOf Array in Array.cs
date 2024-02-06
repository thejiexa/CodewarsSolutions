namespace CodewarsSolutions
{
    public class SearchArrayKata
    {
        public static int SearchArray(object[][] arrayToSearch, object[] query)
        {
            if (query.Length is not 2 || arrayToSearch.Any(sub => sub.Length is not 2))
                throw new Exception();
            
            return Array.FindIndex(arrayToSearch, x => x.SequenceEqual(query));
        }
    }

    [TestFixture]
    public class SearchArrayKataTests
    {
        [Test]
        public void BasicTests()
        {
            var bigArray = new object[][] { new object[] { 2, 3 }, new object[] { 7, 2 }, new object[] { 9, 20 }, new object[] { 1, 2 }, new object[] { 7, 2 }, new object[] { 45, 4 }, new object[] { 7, 87 }, new object[] { 4, 5 }, new object[] { 2, 7 }, new object[] { 6, 32 } };

            var searchFor = new object[] { 9, 20 };
            Assert.That(SearchArrayKata.SearchArray(bigArray, searchFor), Is.EqualTo(2));
            searchFor = new object[] { 1, 12 };
            Assert.That(SearchArrayKata.SearchArray(bigArray, searchFor), Is.EqualTo(-1));
            searchFor = new object[] { 7, 2 };
            Assert.That(SearchArrayKata.SearchArray(bigArray, searchFor), Is.EqualTo(1));
        }
    }
}