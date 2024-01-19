namespace CodewarsSolutions
{
    public class AlphabetWarKata
    {
        public static string AlphabetWar(string fight)
        {
            int score = 0;

            fight.Any(x => x ==
                x switch
                {
                    'w' => score += 4,
                    'p' => score += 3,
                    'b' => score += 2,
                    's' => score++,
                    'm' => score -= 4,
                    'q' => score -= 3,
                    'd' => score -= 2,
                    'z' => score--,
                    _ => null
                });

            return score > 0 ? "Left side wins!" : score < 0 ? "Right side wins!" : "Let's fight again!";
        }
    }

    public class AlphabetWarTest
    {
        [Test]
        public void BasicTest()
        {
            Assert.That(AlphabetWarKata.AlphabetWar("z"), Is.EqualTo("Right side wins!"));
            Assert.That(AlphabetWarKata.AlphabetWar("zdqmwpbs"), Is.EqualTo("Let's fight again!"));
            Assert.That(AlphabetWarKata.AlphabetWar("zzzzs"), Is.EqualTo("Right side wins!"));
            Assert.That(AlphabetWarKata.AlphabetWar("wwwwwwz"), Is.EqualTo("Left side wins!"));
        }
    }
}