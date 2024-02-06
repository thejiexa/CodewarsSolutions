namespace CodewarsSolutions
{
    public class Darts
    {
        public static int ScoreThrows(double[] radii)
        {
            var scores = 0;

            radii.ToList().ForEach(x => scores += x switch
            {
                < 5 => 10,
                <= 10 => 5,
                _ => 0,
            });

            return radii.Length is not 0 && radii.All(x => x < 5) ? scores + 100 : scores;
        }
    }

    [TestFixture]
    public class DartsSolutionTest
    {
        private static object[] sampleTestCases = new object[]
        {
            new object[] {new double[] {1, 5, 11}, 15},
            new object[] {new double[] {15, 20, 30, 31, 32, 44, 100}, 0},
            new object[] {new double[] {1, 2, 3, 4}, 140},
            new object[] {new double[] {}, 0},
            new object[] {new double[] {1, 2, 3, 4, 5, 6, 7, 8, 9}, 65},
            new object[] {new double[] {0, 5, 10, 10.5, 4.5}, 30},
        };

        [Test, TestCaseSource("sampleTestCases")]
        public void SampleTest(double[] test, int expected)
        {
            Assert.AreEqual(expected, Darts.ScoreThrows(test));
        }
    }
}