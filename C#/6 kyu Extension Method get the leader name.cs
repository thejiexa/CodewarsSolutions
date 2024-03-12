namespace CodewarsSolutions
{
    public static class LeaderNameExtension
    {
        public static string? LeaderName(this List<object> groupList)
        {
            PropertyInfo? propertyInfo = groupList.First().GetType().GetProperty("Name", BindingFlags.Public | BindingFlags.Instance);
            return propertyInfo is null ? "Wrong Input!!!" : propertyInfo.GetValue(groupList.First()).ToString();
        }
    }

    [TestFixture]
    public class LeaderNameTest
    {
        [Test]
        public void PeopleListTest()
        {
            List<string> nameList = new List<string>() { "Sarah", "John", "Miko", "Tara", "Ali", "Sasi", "Arya", "David" };
            List<PersonTest> peopleList = new List<PersonTest>();
            for (int i = 0; i < 5; i++)
            {
                string name = nameList[i];
                PersonTest person = new PersonTest() { Name = name };
                peopleList.Add(person);
            }
            List<object> objectList = peopleList.Cast<object>().ToList();
            StringAssert.AreEqualIgnoringCase("Sarah", objectList.LeaderName());
        }

        [Test]
        public void IntegerListTest()
        {
            List<int> intList = new List<int>() { 15, 45, 85, 69, 52 };
            List<object> objectList = intList.Cast<object>().ToList();
            StringAssert.AreEqualIgnoringCase("Wrong Input!!!", objectList.LeaderName());
        }
    }

    public class PersonTest
    {
        public string? Name { get; set; }
    }
}