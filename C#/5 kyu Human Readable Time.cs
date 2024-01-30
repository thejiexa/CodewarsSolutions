namespace CodewarsSolutions
{
    public static class TimeFormat
    {
        //public static string GetReadableTime(int seconds)
        //{
        //    var hours = seconds / 3600;
        //    var minutes = seconds % 3600 / 60;
        //    seconds %= 60;
        //    //return $"{hours:D2}:{minutes:D2}:{seconds:d2}";
        //    return string.Format("{0:00}:{1:00}:{2:00}", hours, minutes, seconds);
        //}

        public static string GetReadableTime(int seconds) =>
            string.Format("{0:00}:{1:00}:{2:00}", seconds / 3600, seconds % 3600 / 60, seconds % 60);
    }

    [TestFixture]
    public class HumanReadableTimeTest
    {
        [Test]
        public void HumanReadableTest()
        {
            Assert.That(TimeFormat.GetReadableTime(0), Is.EqualTo("00:00:00"));
            Assert.That(TimeFormat.GetReadableTime(5), Is.EqualTo("00:00:05"));
            Assert.That(TimeFormat.GetReadableTime(60), Is.EqualTo("00:01:00"));
            Assert.That(TimeFormat.GetReadableTime(86399), Is.EqualTo("23:59:59"));
            Assert.That(TimeFormat.GetReadableTime(359999), Is.EqualTo("99:59:59"));
        }
    }
}