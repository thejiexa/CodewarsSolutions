namespace CodewarsSolutions
{
    public class ToWeirdCaseKata
    {
        public static string ToWeirdCase(string s) =>
            string.Join(" ", s.Split(" ").Select(x => string.Concat(x.Select((letter, i) => i % 2 is 0 ? char.ToUpper(letter) : char.ToLower(letter)))));

        //public static string ToWeirdCase(string s)
        //{
        //    var res = s.Split(" ").Select(x => string.Concat(x.Select((letter, i) => int.IsOddInteger(i) ? char.ToLower(letter) : char.ToUpper(letter))));

        //    return string.Join(" ", res);
        //}
    }

    [TestFixture]
    public class ToWeirdCaseTests
    {
        [Test]
        public static void ShouldWorkForSomeExamples()
        {
            Assert.That(ToWeirdCaseKata.ToWeirdCase("This"), Is.EqualTo("ThIs"));
            Assert.That(ToWeirdCaseKata.ToWeirdCase("is"), Is.EqualTo("Is"));
            Assert.That(ToWeirdCaseKata.ToWeirdCase("This is a test"), Is.EqualTo("ThIs Is A TeSt"));
        }
    }
}