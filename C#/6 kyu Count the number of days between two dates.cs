namespace CodewarsSolutions
{
    public static class GetDaysAliveKata
    {
        public static long GetDaysAlive(int year, int month, int day, int year2, int month2, int day2) =>
            (int)(new DateTime(year2, month2, day2) - new DateTime(year, month, day)).TotalDays;
    }

    [TestFixture]
    public class GetDaysAliveTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.That(GetDaysAliveKata.GetDaysAlive(2000, 1, 1, 2000, 1, 10), Is.EqualTo(9),
                "Should return 9 with [2000.1.1] and [2000.1.10]");

            Assert.That(GetDaysAliveKata.GetDaysAlive(2000, 1, 10, 2000, 1, 1), Is.EqualTo(-9),
                "Should return -9 with [2000.1.10] and [2000.1.1]");

            Assert.That(GetDaysAliveKata.GetDaysAlive(2000, 1, 1, 2000, 1, 1), Is.EqualTo(0),
                "Should return 0 with [2000.1.1] and [2000.1.1]");

            Assert.That(GetDaysAliveKata.GetDaysAlive(1987, 1, 16, 2000, 10, 15), Is.EqualTo(5021),
                "Should return 5021 with [1987.1.16] and [2000.10.15]");

            Assert.That(GetDaysAliveKata.GetDaysAlive(2005, 10, 27, 2017, 4, 6), Is.EqualTo(4179),
                "Should return 4179 with [2005.10.27] and [2017.4.6]");

            Assert.That(GetDaysAliveKata.GetDaysAlive(1998, 1, 10, 2008, 7, 8), Is.EqualTo(3832),
                "Should return 3832 with [1998.1.10] and [2008.7.8]");
        }
    }
}