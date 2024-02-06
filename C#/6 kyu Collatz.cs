namespace CodewarsSolutions
{
    public class CollatzKata
    {
        public static string Collatz(int n)
        {
            if (n is 1)
                return n.ToString();
            string res = $"{n}";
            while (!res.EndsWith("->1"))
            {
                n = n % 2 is 0 ? n / 2 : 3 * n + 1;
                res += $"->{n}";
            }
            return res;
        }
    }

    [TestFixture]
    public class CollatzKataTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.That(CollatzKata.Collatz(3), Is.EqualTo("3->10->5->16->8->4->2->1"));
        }
    }
}