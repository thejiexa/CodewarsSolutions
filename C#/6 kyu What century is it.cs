namespace CodewarsSolutions
{
    public class WhatCenturyKata
    {
        public static string WhatCentury(string input)
        {
            var year = Convert.ToInt32(input);
            var century = year / 100 + (year % 1000 is 0 ? 0 : 1);
            var suffix = century < 20 ? "th" : (century % 10) switch
            {
                1 => "st",
                2 => "nd",
                3 => "rd",
                _ => "th",
            };

            return string.Concat(century, suffix);
        }
    }

    [TestFixture]
    public class WhatCenturyKataTest
    {
        [Test]
        public void BasicTests()
        {
            Assert.That(WhatCenturyKata.WhatCentury("1999"), Is.EqualTo("20th"), "With input '1999' solution produced wrong output.");
            Assert.That(WhatCenturyKata.WhatCentury("2011"), Is.EqualTo("21st"), "With input '2011' solution produced wrong output.");
            Assert.That(WhatCenturyKata.WhatCentury("2154"), Is.EqualTo("22nd"), "With input '2154' solution produced wrong output.");
            Assert.That(WhatCenturyKata.WhatCentury("2259"), Is.EqualTo("23rd"), "With input '2259' solution produced wrong output.");
            Assert.That(WhatCenturyKata.WhatCentury("1284"), Is.EqualTo("13th"), "With input '1284' solution produced wrong output.");
            Assert.That(WhatCenturyKata.WhatCentury("2000"), Is.EqualTo("20th"), "With input '2000' solution produced wrong output.");
        }
    }
}