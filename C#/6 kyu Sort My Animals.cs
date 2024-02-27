namespace CodewarsSolutions
{
    public class Animal
    {
        public string Name { get; set; }
        public int NumberOfLegs { get; set; }
    }

    public class AnimalSorter
    {
        public List<Animal> Sort(List<Animal> input) => input.OrderBy(animal => animal.NumberOfLegs).ThenBy(animal  => animal.Name).ToList();
    }

    [TestFixture]
    public class AnimalSorterTests
    {
        [Test]
        public void SortTest()
        {
            var animals = new List<Animal>
            {
                new Animal {Name = "Cat", NumberOfLegs = 4},
                new Animal {Name = "Snake", NumberOfLegs = 0},
                new Animal {Name = "Dog", NumberOfLegs = 4},
                new Animal {Name = "Pig", NumberOfLegs = 4},
                new Animal {Name = "Human", NumberOfLegs = 2},
                new Animal {Name = "Bird", NumberOfLegs = 2}
            };
            var output = new AnimalSorter().Sort(animals);
            Assert.That("Snake", Is.EqualTo(output[0].Name));
            Assert.That("Cat", Is.EqualTo(output[3].Name));
        }
    }
}