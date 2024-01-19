namespace CodewarsSolutions
{
    public class Deadfish
    {
        public static int[] Parse(string data)
        {

            var result = new List<int>();
            int theNumber = 0;

            data.ToList().ForEach(x => {
                Action action = x switch
                {
                    'i' => () => theNumber++,
                    'd' => () => theNumber--,
                    's' => () => theNumber *= theNumber,
                    'o' => () => result.Add(theNumber),
                    _ => throw new NotImplementedException()
                };

                action();
            });

            return result.ToArray();
        }
    }

    [TestFixture]
    public class DeadfishSolutionTest
    {
        private static object[] sampleTestCases = new object[]
        {
            new object[] {"iiisdoso", new int[] {8, 64}},
            new object[] {"iiisdosodddddiso", new int[] {8, 64, 3600}},
        };

        [Test, TestCaseSource("sampleTestCases")]
        public void SampleTest(string data, int[] expected)
        {
            Assert.That(Deadfish.Parse(data), Is.EqualTo(expected));
        }
    }
}