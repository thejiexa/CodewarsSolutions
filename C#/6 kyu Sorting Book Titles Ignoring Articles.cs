namespace CodewarsSolutions
{
    public class TitleSorter
    {
        public List<string>? Sort(List<string> unsortedTitles)
        {
            var articles = new List<string>() { "The ", "An ", "A " };
            return unsortedTitles?.OrderBy(title => {
                articles.ForEach(article => {
                    if (title.StartsWith(article))
                        title = string.Format("{0}{1}", title.Replace(article, ""), article);
                });
                return title;
            }).ToList();
        }
    }

    [TestFixture]
    public class TitleSorterTests
    {
        [Test]
        public void SampleBooksSortTest()
        {
            List<string> titlesToSort = new List<string>()
            {
                "A Petition to Magic",
                "Heritage of Deceit",
                "Stingers",
                "Billy's Zombie",
                "Heaven and Earth: Paranormal Flash Fiction",
                "Tales From Virdura",
            };
            List<string> sortedList = new TitleSorter().Sort(titlesToSort);
            Assert.That(sortedList.Count, Is.EqualTo(titlesToSort.Count));
            Assert.That(sortedList[0], Is.EqualTo("Billy's Zombie"));
            Assert.That(sortedList[3], Is.EqualTo("A Petition to Magic"));
        }
    }
}