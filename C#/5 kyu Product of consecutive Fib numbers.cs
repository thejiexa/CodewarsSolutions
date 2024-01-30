namespace CodewarsSolutions
{
    public class ProdFib
    {
        public static ulong[] productFib(ulong prod)
        {
            (ulong A, ulong B) fibs = (0, 1);

            while (fibs.A * fibs.B < prod)
                fibs = (fibs.B, fibs.A + fibs.B);

            return new ulong[] {fibs.A, fibs.B, System.Convert.ToUInt64(fibs.A * fibs.B == prod)};
        }
    }

    [TestFixture]
    public class ProdFibTests
    {
        [Test]
        public void Test1()
        {
            ulong[] r = new ulong[] { 55, 89, 1 };
            Assert.That(ProdFib.productFib(4895), Is.EqualTo(r));
        }
    }
}