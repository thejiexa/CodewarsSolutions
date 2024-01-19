namespace CodewarsSolutions
{
    public static class GetParticipantsKata
    {
        public static int GetParticipants(int handshakes)
        {
            var result = 0;
            while (handshakes > (result * (result - 1)) / 2)
                result++;

            return result;
        }
    }

    [TestFixture]
    public class GetParticipantsSolutionTest
    {
        [Test, Description("Basic Tests")]
        public void SampleTest()
        {
            Assert.That(GetParticipantsKata.GetParticipants(0), Is.EqualTo(0));
            Assert.That(GetParticipantsKata.GetParticipants(1), Is.EqualTo(2));
            Assert.That(GetParticipantsKata.GetParticipants(3), Is.EqualTo(3));
            Assert.That(GetParticipantsKata.GetParticipants(6), Is.EqualTo(4));
            Assert.That(GetParticipantsKata.GetParticipants(7), Is.EqualTo(5));
        }
    }
}