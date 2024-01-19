namespace CodewarsSolutions
{
    public class XbonacciKata
    {
        public static double[] xbonacci(double[] signature, int n)
        {
            if (signature.Length > n)
                return signature.Take(n).ToArray();

            var list = signature.ToList();
            for (int i = 0; i < n - signature.Length; i++)
                list.Add(list.GetRange(i, signature.Length).Sum());

            return list.ToArray();
        }
    }

    public class XbonacciKataTests
    {
        [Test]
        public void Test()
        {
            Assert.That(XbonacciKata.xbonacci(new double[] { 0, 1 }, 10), Is.EqualTo(new double[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 }));
            Assert.That(XbonacciKata.xbonacci(new double[] { 1, 1 }, 10), Is.EqualTo(new double[] { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 }));
            Assert.That(XbonacciKata.xbonacci(new double[] { 0, 0, 0, 0, 1 }, 10), Is.EqualTo(new double[] { 0, 0, 0, 0, 1, 1, 2, 4, 8, 16 }));
            Assert.That(XbonacciKata.xbonacci(new double[] { 0, 0, 0, 0, 1 }, 11), Is.EqualTo(new double[] { 0, 0, 0, 0, 1, 1, 2, 4, 8, 16, 31 }));
            Assert.That(XbonacciKata.xbonacci(new double[] { 1, 0, 0, 0, 0, 0, 1 }, 10), Is.EqualTo(new double[] { 1, 0, 0, 0, 0, 0, 1, 2, 3, 6 }));
            Assert.That(XbonacciKata.xbonacci(new double[] { 1, 2, 3 }, 5), Is.EqualTo(new double[] { 1, 2, 3, 6, 11 }));
        }
    }
}