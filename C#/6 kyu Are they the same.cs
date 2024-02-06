namespace CodewarsSolutions
{
    class AreTheySame
    {
        public static bool comp(int[] a, int[] b) =>
            a is not null && b is not null && a.OrderBy(_ => _).Select(x => x * x).SequenceEqual(b.OrderBy(_ => _));

        //public static bool comp(int[] a, int[] b)
        //{
        //    if (a is null || b is null)
        //        return false;

        //    a = a.OrderBy(_ => _).Select(x => x * x).ToArray();
        //    b = b.OrderBy(_ => _).ToArray();

        //    return a.SequenceEqual(b);
        //}
    }

    [TestFixture]
    public class AreTheySameTests
    {

        [Test]
        public void Test1()
        {
            int[] a = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };
            int[] b = new int[] { 11 * 11, 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 19 * 19 };
            bool r = AreTheySame.comp(a, b); // True
            Assert.That(r, Is.EqualTo(true));
        }

        [Test]
        public void Test2()
        {
            int[] a = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };
            int[] b = new int[] { 132, 14641, 20736, 361, 25921, 361, 20736, 361 };
            bool r = AreTheySame.comp(a, b);
            Assert.That(r, Is.EqualTo(false));
        }
    }
}