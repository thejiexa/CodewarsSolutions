namespace CodewarsSolutions
{
    public class DayCountKata
    {
        public string countDays(DateTime d)
        {
            var days = Math.Round((d - DateTime.Now).TotalDays);
            return days switch
            {
                < 0 => "The day is in the past!",
                0 => "Today is the day!",
                _ => $"{days} days"
            };
        }
    }

    [TestFixture]
    public class DayCountTest
    {

        [Test]
        public void DefaultTests()
        {
            DayCountKata d = new DayCountKata();
            Assert.That(d.countDays(new DateTime(2016, 12, 2)), Is.EqualTo("The day is in the past!"));
            Assert.That(d.countDays(DateTime.Now), Is.EqualTo("Today is the day!"));
        }
    }
}