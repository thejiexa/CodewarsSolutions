namespace CodewarsSolutions
{
    class WhichAreIn
    {
        public static string[] inArray(string[] array1, string[] array2) => 
            array2.SelectMany(x => array1.Where(y => x.Contains(y))).Distinct().OrderBy(_ => _).ToArray();
    }

    [TestFixture]
    public class WhichAreInTests
    {
        [Test]
        public void Test1()
        {
            string[] a1 = new string[] { "arp", "live", "strong" };
            string[] a2 = new string[] { "lively", "alive", "harp", "sharp", "armstrong" };
            string[] r = new string[] { "arp", "live", "strong" };
            Assert.That(WhichAreIn.inArray(a1, a2), Is.EqualTo(r));
        }
    }
}