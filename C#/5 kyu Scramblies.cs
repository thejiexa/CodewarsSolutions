namespace CodewarsSolutions
{
    public class Scramblies
    {
        public static bool Scramble(string str1, string str2) => 
            !str2.GroupBy(_ => _).Any(x => str1.Count(c => c == x.Key) < x.Count());

        //public static bool Scramble(string str1, string str2)
        //{
        //    foreach (var item in str2)
        //    {
        //        if (str1.Count(x => x == item) < str2.Count(x => x == item))
        //        {
        //            return false;
        //        }
        //    }

        //    return true;
        //}
    }

    [TestFixture]
    public static class ScrambliesTests
    {
        private static void testing(bool actual, bool expected)
        {
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public static void test1()
        {
            testing(Scramblies.Scramble("rkqodlw", "world"), true);
            testing(Scramblies.Scramble("cedewaraaossoqqyt", "codewars"), true);
            testing(Scramblies.Scramble("katas", "steak"), false);
            testing(Scramblies.Scramble("scriptjavx", "javascript"), false);
            testing(Scramblies.Scramble("scriptingjava", "javascript"), true);
            testing(Scramblies.Scramble("scriptsjava", "javascripts"), true);
            testing(Scramblies.Scramble("javscripts", "javascript"), false);
            testing(Scramblies.Scramble("aabbcamaomsccdd", "commas"), true);
            testing(Scramblies.Scramble("commas", "commas"), true);
            testing(Scramblies.Scramble("sammoc", "commas"), true);
        }
    }
}