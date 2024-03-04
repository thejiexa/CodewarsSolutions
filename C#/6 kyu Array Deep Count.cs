namespace CodewarsSolutions
{
    public class DeepCountKata
    {
        public static int DeepCount(object a) => ((object[])a).Sum(x => (x is Array) ? DeepCount(x) + 1 : 1);
    }

    [TestFixture]
    public class DeepCountSolutionTest
    {
        private static object[] Basic_Test_Cases = new object[]
        {
            new object[]
            {
                new object[] {},
                0
            },
            new object[]
            {
                new object[] {1, 2, 3},
                3
            },
            new object[]
            {
                new object[] {"x", "y", new object[] {"z"}},
                4
            },
            new object[]
            {
                new object[] {1, 2, new object[] {3, 4, new object[] {5}}},
                7
            },
            new object[]
            {
                new object[] { new object[] { new object[] { new object[] { new object[] { new object[] { new object[] { new object[] { new object[] {}}}}}}}}},
                8
            }
        };

        [Test, TestCaseSource(typeof(DeepCountSolutionTest), "Basic_Test_Cases")]
        public void Basic_Tests(object test, int expected)
        {
            Assert.That(DeepCountKata.DeepCount(test), Is.EqualTo(expected), $"Expected {expected}");
        }
    }
}