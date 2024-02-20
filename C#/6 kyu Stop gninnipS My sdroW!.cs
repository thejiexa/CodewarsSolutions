﻿namespace CodewarsSolutions
{
    public class SpinWordsKata
    {
        public static string SpinWords(string sentence) => string.Join(" ", sentence.Split(" ").Select(x => x.Length > 4 ? string.Concat(x.Reverse()) : x));
    }

    [TestFixture]
    public class SpinWordsTests
    {
        [Test]
        public static void Test1() => Assert.That(SpinWordsKata.SpinWords("Welcome"), Is.EqualTo("emocleW"));

        [Test]
        public static void Test2() => Assert.That(SpinWordsKata.SpinWords("Hey fellow warriors"), Is.EqualTo("Hey wollef sroirraw"));

        [Test]
        public static void Test3() => Assert.That(SpinWordsKata.SpinWords("This is a test"), Is.EqualTo("This is a test"));

        [Test]
        public static void Test4() => Assert.That(SpinWordsKata.SpinWords("This is another test"), Is.EqualTo("This is rehtona test"));
        
        [Test]
        public static void Test5() => Assert.That(SpinWordsKata.SpinWords("You are almost to the last test"), Is.EqualTo("You are tsomla to the last test"));

        [Test]
        public static void Test6() => Assert.That(SpinWordsKata.SpinWords("Just kidding there is still one more"), Is.EqualTo("Just gniddik ereht is llits one more"));
    }
}