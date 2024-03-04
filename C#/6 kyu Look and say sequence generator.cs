namespace CodewarsSolutions
{
    class LookAndSaySequenceKata
    {
        public static string LookAndSaySequence(string firstElement, long n)
        {
            if (string.IsNullOrEmpty(firstElement) || firstElement is "22" || n is 1)
                return firstElement;

            var sequence = new List<string>
            {
                firstElement
            };

            while (sequence.Count < n)
            {
                var list = sequence.Last().Skip(1).Aggregate(new List<string> { sequence.Last().First().ToString() }, (x, i) => {
                    if (i != x.Last().First()) x.Add(i.ToString());
                    else x[^1] += i;
                    return x;
                });

                sequence.Add(string.Concat(list.Select(x => $"{x.Length}{x.First()}")));
            }

            return sequence.Last();
        }
    }

    class LookAndSaySequenceTest
    {
        [Test]
        public void FixedTest()
        {
            Assert.That(LookAndSaySequenceKata.LookAndSaySequence("1", 1), Is.EqualTo("1"));
            Assert.That(LookAndSaySequenceKata.LookAndSaySequence("1", 3), Is.EqualTo("21"));
            Assert.That(LookAndSaySequenceKata.LookAndSaySequence("1", 5), Is.EqualTo("111221"));
            Assert.That(LookAndSaySequenceKata.LookAndSaySequence("22", 10), Is.EqualTo("22"));
            Assert.That(LookAndSaySequenceKata.LookAndSaySequence("14", 2), Is.EqualTo("1114"));
        }
    }
}