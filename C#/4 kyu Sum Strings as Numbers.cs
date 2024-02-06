namespace CodewarsSolutions
{
    public static class SumStringsKata
    {
        public static string sumStrings(string a, string b)
        {
            a = a.TrimStart('0');
            b = b.TrimStart('0');
            var diff = Math.Max(a.Length, b.Length);
            var first = a.PadLeft(diff, '0').ToCharArray().Reverse().ToList().ConvertAll(x => (int)char.GetNumericValue(x));
            var second = b.PadLeft(diff, '0').ToCharArray().Reverse().ToList().ConvertAll(x => (int)char.GetNumericValue(x));
            var res = new List<int>();
            var temp = 0;

            for (int i = 0; i < first.Count; i++)
            {
                res.Add((first[i] + second[i] + temp) % 10);
                temp = (first[i] + second[i] + temp) / 10;
            }

            if (temp is not 0)
                res.Add(temp);

            res.Reverse();

            return string.Concat(res);
        }
    }

    [TestFixture]
    public class SumStringsTest
    {
        [Test]
        public void Given123And456Returns579() => Assert.That(SumStringsKata.sumStrings("123", "456"), Is.EqualTo("579"));
        
        [Test]
        public void Given00103And08567Returns8670() => Assert.That(SumStringsKata.sumStrings("00103", "08567"), Is.EqualTo("8670"));
    }
}