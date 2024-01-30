namespace CodewarsSolutions
{
    public class FindTheParityOutlierKata
    {
        public static int Find(int[] integers)
        {
            var odd = integers.Where(x => x % 2 is 0);
            var even = integers.Where(x => x % 2 is not 0);

            return odd.Count() is 1 ? odd.First() : even.First();
        }
    }

    [TestFixture]
    public class FindTheParityOutlierKataTests
    {
        [Test]
        public static void Test1()
        {
            int[] exampleTest1 = { 2, 6, 8, -10, 3 };
            Assert.IsTrue(3 == FindTheParityOutlierKata.Find(exampleTest1));
        }

        [Test]
        public static void Test2()
        {
            int[] exampleTest2 = { 206847684, 1056521, 7, 17, 1901, 21104421, 7, 1, 35521, 1, 7781 };
            Assert.IsTrue(206847684 == FindTheParityOutlierKata.Find(exampleTest2));
        }

        [Test]
        public static void Test3()
        {
            int[] exampleTest3 = { int.MaxValue, 0, 1 };
            Assert.IsTrue(0 == FindTheParityOutlierKata.Find(exampleTest3));
        }
    }
}