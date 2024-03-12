namespace CodewarsSolutions
{
    public class NextHigherKata
    {
        public int nextHigher(int value)
        {
            int bits = Convert.ToString(value, 2).Count(x => x is '1');
            return Enumerable.Range(value + 1, int.MaxValue - value).First(n => Convert.ToString(n, 2).Count(x => x is '1') == bits);
        }
    }

    public class NextHigherKataTest
    {
        [Test]
        public void smile67KataTest_withoutRandom1() => Assert.That(new NextHigherKata().nextHigher(128), Is.EqualTo(256));
        [Test]
        public void smile67KataTest_withoutRandom2() => Assert.That(new NextHigherKata().nextHigher(1), Is.EqualTo(2));
        [Test]
        public void smile67KataTest_withoutRandom3() => Assert.That(new NextHigherKata().nextHigher(1022), Is.EqualTo(1279));
        [Test]
        public void smile67KataTest_withoutRandom4() => Assert.That(new NextHigherKata().nextHigher(127), Is.EqualTo(191));
        [Test]
        public void smile67KataTest_withoutRandom5() => Assert.That(new NextHigherKata().nextHigher(1253343), Is.EqualTo(1253359)); 
    }
}