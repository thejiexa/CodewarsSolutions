namespace CodewarsSolutions
{
    public class MinuteCount
    {
        public string countMinutes(DateTime d)
        {
            var minutes = (int)Math.Round((d.Date.AddDays(1) - d).TotalMinutes);
            return $"{minutes} minute{(minutes is not 1 ? 's' : "")}";
        }
    }

    [TestFixture]
    public class MinuteCountTest
    {
        [Test]
        public void exampleTests()
        {
            MinuteCount m = new MinuteCount();
            DateTime testDate = DateTime.Now.Date.AddHours(12);
            Assert.That(m.countMinutes(testDate), Is.EqualTo("720 minutes"));

            testDate = DateTime.Now.Date.AddHours(23).AddMinutes(59);
            Assert.That(m.countMinutes(testDate), Is.EqualTo("1 minute"));
        }
    }
}