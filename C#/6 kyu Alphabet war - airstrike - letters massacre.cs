namespace CodewarsSolutions
{
    public class AlphabetWarAirstrikeKata
    {
        public static string AlphabetWar(string fight)
        {
            if (fight.Contains('*'))
            {
                var list = fight.Split('*');
                var bombed = list.Select((x, i) => {
                    if (x.Length > 1)
                    {
                        return i switch
                        {
                            0 => x[..^1],
                            int lastIndex when lastIndex == list.Length - 1 => x[1..],
                            _ => x[1..^1],
                        };
                    }
                    else return string.Empty;
                });

                fight = string.Concat(bombed);
            }

            int scores = 0;

            fight.ToList().ForEach(x => scores += x switch
            {
                'w' => 4,
                'p' => 3,
                'b' => 2,
                's' => 1,
                'm' => -4,
                'q' => -3,
                'd' => -2,
                'z' => -1,
                _ => 0
            });

            return scores > 0 ? "Left side wins!" : scores < 0 ? "Right side wins!" : "Let's fight again!";
        }
    }

    [TestFixture]
    public class AlphabetWarAirstrikeTest
    {
        [Test]
        public void BasicTest()
        {
            Assert.Multiple(() =>
            {
                Assert.That(AlphabetWarAirstrikeKata.AlphabetWar("z"), Is.EqualTo("Right side wins!"));
                Assert.That(AlphabetWarAirstrikeKata.AlphabetWar("****"), Is.EqualTo("Let's fight again!"));
                Assert.That(AlphabetWarAirstrikeKata.AlphabetWar("z*dq*mw*pb*s"), Is.EqualTo("Let's fight again!"));
                Assert.That(AlphabetWarAirstrikeKata.AlphabetWar("zdqmwpbs"), Is.EqualTo("Let's fight again!"));
                Assert.That(AlphabetWarAirstrikeKata.AlphabetWar("zz*zzs"), Is.EqualTo("Right side wins!"));
                Assert.That(AlphabetWarAirstrikeKata.AlphabetWar("*wwwwww*z*"), Is.EqualTo("Left side wins!"));
                Assert.That(AlphabetWarAirstrikeKata.AlphabetWar("stq*"), Is.EqualTo("Left side wins!"));
                Assert.That(AlphabetWarAirstrikeKata.AlphabetWar("c*w"), Is.EqualTo("Let's fight again!"));
            });
        }
    }
}