namespace CodewarsSolutions
{
    public class NthFibonacci
    {
        public int NthFib(int n) =>
            n < 2 ? 0 : n == 2 ? 1 : NthFib(n - 1) + NthFib(n - 2);
    }

    [TestFixture]
    public class NthFibonacciTests
    {
        [Test]
        public void Test()
        {
            NthFibonacci fib = new NthFibonacci();
            Assert.That(fib.NthFib(1), Is.EqualTo(0));
            Assert.That(fib.NthFib(2), Is.EqualTo(1));
            Assert.That(fib.NthFib(3), Is.EqualTo(1));
            Assert.That(fib.NthFib(4), Is.EqualTo(2));
        }
    }
}