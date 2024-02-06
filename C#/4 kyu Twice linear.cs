namespace CodewarsSolutions
{
    public class DoubleLinear
    {
        public static int DblLinear(int n)
        {
            var sortedSet = new SortedSet<int>() { 1 };

            while (n > 0)
            {
                int x = sortedSet.Min;
                sortedSet.Add(2 * x + 1);
                sortedSet.Add(3 * x + 1);
                sortedSet.Remove(x);
                n--;
            }

            return sortedSet.Min;
        }
    }

    [TestFixture]
    public static class DoubleLinearTests
    {
        private static void testing(int actual, int expected) => Assert.That(actual, Is.EqualTo(expected));

        [Test]
        public static void test1()
        {
            Console.WriteLine("Fixed Tests DblLinear");
            testing(DoubleLinear.DblLinear(10), 22);
            testing(DoubleLinear.DblLinear(20), 57);
            testing(DoubleLinear.DblLinear(30), 91);
            testing(DoubleLinear.DblLinear(50), 175);
        }
    }
}