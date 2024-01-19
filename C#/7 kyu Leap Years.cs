namespace CodewarsSolutions
{
    public static class LeapYearKata
    {
        public static bool IsLeapYear(int year) =>
            year % 4 is 0 && year % 100 is not 0 || year % 400 is 0;
    }

    [TestFixture]
    public static class LeapYearTests
    {
        [Test]
        public static void TestYear2020() =>
            Assert.That(LeapYearKata.IsLeapYear(2020), Is.EqualTo(true));

        [Test]
        public static void TestYear2000() =>
            Assert.That(LeapYearKata.IsLeapYear(2000), Is.EqualTo(true));

        [Test]
        public static void TestYear2015() =>
            Assert.That(LeapYearKata.IsLeapYear(2015), Is.EqualTo(false));

        [Test]
        public static void TestYear2100() =>
            Assert.That(LeapYearKata.IsLeapYear(2100), Is.EqualTo(false));
    }
}