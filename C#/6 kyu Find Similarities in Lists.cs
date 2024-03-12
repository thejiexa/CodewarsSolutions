namespace CodewarsSolutions
{
    public class AnySimilarityKata
    {
        public static string AnySimilarity(List<int> firstList, List<int> secondList, int n)
        {
            List<string> sequences = new List<string>();

            for (int i = 0; i <= firstList.Count - n; i++)
            {
                var sequence1 = firstList.Skip(i).Take(n).ToList();
                for (int j = 0; j <= secondList.Count - n; j++)
                {
                    var sequence2 = secondList.Skip(j).Take(n).ToList();
                    if (sequence2.SequenceEqual(sequence1))
                    {
                        sequences.Add(string.Join(',', sequence1));
                    }
                }
            }

            return string.Join(" | ", sequences.Distinct());
        }
    }

    [TestFixture]
    public class AnySimilarityTest
    {
        [Test]
        public void FirstTest()
        {
            List<int> first = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<int> second = new List<int>() { 5, 7, 8, 0, 2, 3, 4, 10 };
            int n = 2;
            StringAssert.AreEqualIgnoringCase("2,3 | 3,4", AnySimilarityKata.AnySimilarity(first, second, n));
        }

        [Test]
        public void SecondTest()
        {
            List<int> first = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<int> second = new List<int>() { 5, 7, 8, 0, 2, 3, 4, 10 };
            int n = 3;
            StringAssert.AreEqualIgnoringCase("2,3,4", AnySimilarityKata.AnySimilarity(first, second, n));
        }
    }
}