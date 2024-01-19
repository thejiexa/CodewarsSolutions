namespace CodewarsSolutions
{
    public class Xbonacci
    {
        public static double[] Tribonacci(double[] signature, int n)
        {
            return n switch
            {
                0 => new double[0],
                1 => new double[] { signature[0] },
                2 => new double[] { signature[0], signature[1] },
                _ => Threeplus()
            };

            double[] Threeplus()
            {
                var list = new List<double>(n);
                list.AddRange(signature);
                for (int i = 3; i < list.Capacity; i++)
                    list.Add(list[i - 1] + list[i - 2] + list[i - 3]);
                return list.ToArray();
            }
        }
    }

    public class XbonacciTests
    {
        [Test]
        public void Test()
        {
            Assert.That(Xbonacci.Tribonacci(new double[] { 1, 1, 1 }, 10), Is.EqualTo(new double[] { 1, 1, 1, 3, 5, 9, 17, 31, 57, 105 }));
            Assert.That(Xbonacci.Tribonacci(new double[] { 0, 0, 1 }, 10), Is.EqualTo(new double[] { 0, 0, 1, 1, 2, 4, 7, 13, 24, 44 }));
            Assert.That(Xbonacci.Tribonacci(new double[] { 0, 1, 1 }, 10), Is.EqualTo(new double[] { 0, 1, 1, 2, 4, 7, 13, 24, 44, 81 }));
            Assert.That(Xbonacci.Tribonacci(new double[] { 0, 1, 1 }, 0), Is.EqualTo(new double[] { }));
            Assert.That(Xbonacci.Tribonacci(new double[] { 3, 2, 1 }, 10), Is.EqualTo(new double[] { 3, 2, 1, 6, 9, 16, 31, 56, 103, 190 }));
        }
    }
}