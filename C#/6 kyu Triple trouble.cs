namespace CodewarsSolutions
{
    public class TripleDoubleKata
    {
        //public static int TripleDouble(long num1, long num2)
        //{
        //    var n1 = num1.ToString();
        //    var n2 = num2.ToString();
        //    for (int i = 0; i < 10; i++)
        //    {
        //        if (n1.Contains($"{i}{i}{i}") && n2.Contains($"{i}{i}"))
        //        {
        //            return 1;
        //        }
        //    }
        //    return 0;
        //}

        public static int TripleDouble(long num1, long num2) => Enumerable.Range(0, 10).Any(i => num1.ToString().Contains($"{i}{i}{i}") && num2.ToString().Contains($"{i}{i}")) ? 1 : 0;
    }

    [TestFixture]
    public class TripleDoubleTests
    {
        [Test]
        [TestCase(451999277, 41177722899, ExpectedResult = 1)]
        [TestCase(1222345, 12345, ExpectedResult = 0)]
        [TestCase(12345, 12345, ExpectedResult = 0)]
        [TestCase(666789, 12345667, ExpectedResult = 1)]
        [TestCase(10560002, 100, ExpectedResult = 1)]
        [TestCase(1112, 122, ExpectedResult = 0)]
        public static int FixedTest(long s1, long s2)
        {
            return TripleDoubleKata.TripleDouble(s1, s2);
        }
    }
}