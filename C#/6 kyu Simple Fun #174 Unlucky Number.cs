namespace CodewarsSolutions
{
    public class SimpleFunUnluckyNumberKata
    {
        public int UnluckyNumber(int n)
        {
            var res = new List<int>();

            for (int i = 0; i <= n; i += 13)
            {
                if (!i.ToString().Contains('4') && !i.ToString().Contains('7'))
                    res.Add(i);
            }

            return res.Count;
        }
    }

    [TestFixture]
    public class SimpleFunUnluckyNumberTest
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFunUnluckyNumberKata();
            Assert.That(kata.UnluckyNumber(20), Is.EqualTo(2));
            Assert.That(kata.UnluckyNumber(100), Is.EqualTo(7));
            Assert.That(kata.UnluckyNumber(1000), Is.EqualTo(40));
            Assert.That(kata.UnluckyNumber(1000000), Is.EqualTo(20182));
        }
    }
}