namespace CodewarsSolutions
{
    public class RgbKata
    {
        public static string Rgb(int r, int g, int b) => 
            string.Format("{0:X2}{1:X2}{2:X2}", Math.Clamp(r, 0, 255), Math.Clamp(g, 0, 255), Math.Clamp(b, 0, 255));
    }

    public class RgbTests
    {
        [TestFixture]
        public class KataTests
        {
            [Test]
            public void FixedTests()
            {
                Assert.That(RgbKata.Rgb(255, 255, 255), Is.EqualTo("FFFFFF"));
                Assert.That(RgbKata.Rgb(255, 255, 300), Is.EqualTo("FFFFFF"));
                Assert.That(RgbKata.Rgb(0, 0, 0), Is.EqualTo("000000"));
                Assert.That(RgbKata.Rgb(148, 0, 211), Is.EqualTo("9400D3"));
                Assert.That(RgbKata.Rgb(148, -20, 211), Is.EqualTo("9400D3"), "Handle negative numbers.");
                Assert.That(RgbKata.Rgb(144, 195, 212), Is.EqualTo("90C3D4"));
                Assert.That(RgbKata.Rgb(212, 53, 12), Is.EqualTo("D4350C"), "Consider single hex digit numbers.");
            }
        }
    }
}