namespace CodewarsSolutions
{
    public static class AcrosticReaderKata
    {
        public static string ReadOut(string[] acrostic) => string.Join("", acrostic.Select(x => x.First()));
    }

    [TestFixture]
    public class AcrosticReaderSolutionTest
    {
        [Test, Description("Sample Tests")]
        public void SampleTest()
        {
            Assert.That(AcrosticReaderKata.ReadOut(["Jolly", "Amazing", "Courteous", "Keen"]), Is.EqualTo("JACK"));
            Assert.That(AcrosticReaderKata.ReadOut(["Marvelous", "Excellent", "Gifted"]), Is.EqualTo("MEG"));
        }
    }
}