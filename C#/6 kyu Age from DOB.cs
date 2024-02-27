namespace CodewarsSolutions
{
    public class GetAgeFromDOBKata
    {
        private readonly IClock clock;

        public GetAgeFromDOBKata(IClock clock) => this.clock = clock;
        
        public int GetAgeFromDOB(DateTime birthday)
        {
            var now = clock.Now;
            var age = now.Year - birthday.Year;
            return now < birthday.AddYears(age) ? --age : age;
        }
    }

    public interface IClock
    {
        DateTime Now { get; }
    }

    public class SystemClock : IClock
    {
        public DateTime Now => DateTime.Now;
    }

    public class StaticClock : IClock
    {
        private readonly DateTime dateTime;

        public StaticClock(DateTime dateTime) => this.dateTime = dateTime;

        public DateTime Now => dateTime;
    }

    [TestFixture]
    public class GetAgeFromDOBTests
    {
        private GetAgeFromDOBKata kata;

        [Test]
        public void SystemClock_IsEqualWithDateTimeNow()
        {
            Assert.That(new SystemClock().Now.Year, Is.EqualTo(DateTime.Now.Year));
            Assert.That(new SystemClock().Now.Month, Is.EqualTo(DateTime.Now.Month));
            Assert.That(new SystemClock().Now.Day, Is.EqualTo(DateTime.Now.Day));
        }

        [Test]
        public void GetAgeFromDOB()
        {
            kata = new GetAgeFromDOBKata(new StaticClock(new DateTime(2008, 09, 3)));
            Assert.That(kata.GetAgeFromDOB(new DateTime(1984, 04, 23)), Is.EqualTo(24));
        }
    }
}