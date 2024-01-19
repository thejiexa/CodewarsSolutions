namespace CodewarsSolutions
{
    public static class UniqueInOrderKata
    {
        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            List<T> res = new List<T>();

            foreach (T item in iterable)
                if (!res.Contains(item) || res.LastIndexOf(item) != res.Count - 1)
                    res.Add(item);

            return res;
        }
    }

    public class UniqueInOrderTests
    {
        [Test]
        public void EmptyTest() => Assert.That(UniqueInOrderKata.UniqueInOrder(""), Is.EqualTo(""));

        [Test]
        public void Test1() => Assert.That(UniqueInOrderKata.UniqueInOrder("AAAABBBCCDAABBB"), Is.EqualTo("ABCDAB"));
    }
}