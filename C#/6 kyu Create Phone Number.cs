namespace CodewarsSolutions
{
    public class CreatePhoneNumberKata
    {
        public static string CreatePhoneNumber(int[] numbers) =>
            string.Join("", numbers).Insert(0, "(").Insert(4, ") ").Insert(9, "-");
    }

    public class CreatePhoneNumberTests
    {
        [TestFixture]
        public class Test
        {
            [Test]
            [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }, ExpectedResult = "(123) 456-7890")]
            [TestCase(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, ExpectedResult = "(111) 111-1111")]
            public static string FixedTest(int[] numbers)
            {
                return CreatePhoneNumberKata.CreatePhoneNumber(numbers);
            }
        }
    }
}