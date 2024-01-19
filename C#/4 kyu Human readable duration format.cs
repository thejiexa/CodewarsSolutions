namespace CodewarsSolutions
{
    public class HumanTimeFormat
    {
        public static string formatDuration(int seconds)
        {
            if (seconds is 0) return "now";

            TimeSpan ts = TimeSpan.FromSeconds(seconds);

            Dictionary<string, int> map = new()
            {
                [ts.Days / 365 is 1 ? "year" : "years"] = ts.Days / 365,
                [ts.Days % 365 is 1 ? "day" : "days"] = ts.Days % 365,
                [ts.Hours is 1 ? "hour" : "hours"] = ts.Hours,
                [ts.Minutes is 1 ? "minute" : "minutes"] = ts.Minutes,
                [ts.Seconds is 1 ? "second" : "seconds"] = ts.Seconds
            };

            var list = string.Concat(map.Select(x => x.Value is not 0 ? $"{x.Value} {x.Key} " : "")).TrimEnd().Split().ToList();

            if (list.Count > 2)
                list.Insert(list.Count - 2, "and");

            for (int i = 1; i < list.Count - 5; i += 2)
                list[i] = string.Concat(list[i], ",");

            return string.Join(" ", list);
        }
    }

    [TestFixture]
    public class HumanTimeFormatTests
    {
        [Test]
        public void basicTests()
        {
            Assert.That(HumanTimeFormat.formatDuration(0), Is.EqualTo("now"));
            Assert.That(HumanTimeFormat.formatDuration(1), Is.EqualTo("1 second"));
            Assert.That(HumanTimeFormat.formatDuration(62), Is.EqualTo("1 minute and 2 seconds"));
            Assert.That(HumanTimeFormat.formatDuration(120), Is.EqualTo("2 minutes"));
            Assert.That(HumanTimeFormat.formatDuration(3662), Is.EqualTo("1 hour, 1 minute and 2 seconds"));
            Assert.That(HumanTimeFormat.formatDuration(15731080), Is.EqualTo("182 days, 1 hour, 44 minutes and 40 seconds"));
            Assert.That(HumanTimeFormat.formatDuration(132030240), Is.EqualTo("4 years, 68 days, 3 hours and 4 minutes"));
            Assert.That(HumanTimeFormat.formatDuration(205851834), Is.EqualTo("6 years, 192 days, 13 hours, 3 minutes and 54 seconds"));
            Assert.That(HumanTimeFormat.formatDuration(253374061), Is.EqualTo("8 years, 12 days, 13 hours, 41 minutes and 1 second"));
            Assert.That(HumanTimeFormat.formatDuration(242062374), Is.EqualTo("7 years, 246 days, 15 hours, 32 minutes and 54 seconds"));
            Assert.That(HumanTimeFormat.formatDuration(101956166), Is.EqualTo("3 years, 85 days, 1 hour, 9 minutes and 26 seconds"));
            Assert.That(HumanTimeFormat.formatDuration(33243586), Is.EqualTo("1 year, 19 days, 18 hours, 19 minutes and 46 seconds"));
        }
    }
}