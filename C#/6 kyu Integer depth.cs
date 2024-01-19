namespace CodewarsSolutions
{
    public class ComputeDepthKata
    {
        public static int ComputeDepth(int n)
        {
            var list = new List<char>();
            int i = 1;

            while (list.Count is not 10)
            {
                foreach (var item in (n * i).ToString())
                    if (!list.Contains(item))
                        list.Add(item);
                i++;
            };

            return i - 1;
        }
    }

    [TestFixture]
    public class ComputeDepthSolutionTest
    {
        [Test]
        public void SampleTest1() => Assert.That(ComputeDepthKata.ComputeDepth(1), Is.EqualTo(10));

        [Test]
        public void SampleTest2() => Assert.That(ComputeDepthKata.ComputeDepth(42), Is.EqualTo(9));
    }
}