namespace CodewarsSolutions
{
    public class DirReduction
    {
        public static string[] dirReduc(String[] arr)
        {
            var pairs = new Dictionary<string, string>()
            {
                { "NORTH", "SOUTH" },
                { "SOUTH", "NORTH" },
                { "EAST", "WEST" },
                { "WEST", "EAST" }
            };

            var list = arr.ToList();

            for (int i = 0; i < list.Count - 1; i++)
            {
                if (pairs[list[i]] == list[i + 1])
                {
                    list.RemoveRange(i, 2);
                    arr = dirReduc(list.ToArray());
                }
            }

            return arr;
        }
    }

    [TestFixture]
    public class DirReductionTests
    {
        [Test]
        public void Test1()
        {
            string[] a = new string[] { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST" };
            string[] b = new string[] { "WEST" };
            Assert.That(DirReduction.dirReduc(a), Is.EqualTo(b));
        }

        [Test]
        public void Test2()
        {
            string[] a = new string[] { "NORTH", "WEST", "SOUTH", "EAST" };
            string[] b = new string[] { "NORTH", "WEST", "SOUTH", "EAST" };
            Assert.That(DirReduction.dirReduc(a), Is.EqualTo(b));
        }
    }
}