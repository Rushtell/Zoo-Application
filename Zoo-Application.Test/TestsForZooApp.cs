using System;
using Xunit;

namespace Zoo_Application.Test
{
    public class TestsForZooApp
    {
        [Fact]
        public void Test1()
        {
            ZooApp zooApp = new ZooApp();

            Zoo zoo = new Zoo("Forest");

            zooApp.AddZoo(zoo);

            zoo.AddEnclosure("Enclosure1", 10000);
            zoo.AddEnclosure("Enclosure2", 1000);

            Veterinarian veterinarian1 = new Veterinarian() { FirstName = "Karlson", LastName = "Krishin" };
            veterinarian1.AddAnimalExperience(typeof(Elephant).ToString());

            Veterinarian veterinarian2 = new Veterinarian() { FirstName = "Valera", LastName = "Baklagan" };
            veterinarian1.AddAnimalExperience(typeof(Turtle).ToString());

            ZooKeeper zooKeeper1 = new ZooKeeper() { FirstName = "Shkaf", LastName = "Petrov" };
            zooKeeper1.AddAnimalExperience(typeof(Elephant).ToString());

            ZooKeeper zooKeeper2 = new ZooKeeper() { FirstName = "Olen", LastName = "Vasiliev" };
            zooKeeper2.AddAnimalExperience(typeof(Turtle).ToString());

            zoo.HireEmployee(veterinarian1);
            zoo.HireEmployee(veterinarian2);
            zoo.HireEmployee(zooKeeper1);
            zoo.HireEmployee(zooKeeper2);

            Elephant elephant = new Elephant() { ID = 1, favoriteFood = typeof(Vegetable).ToString(), sick = true };
            Turtle turtle = new Turtle() { ID = 2, favoriteFood = typeof(Vegetable).ToString(), sick = true };

            var test1 = zoo.FindAvailableEnclosure(elephant);
            zoo.FindAvailableEnclosure(elephant).AddAnimals(elephant);
            var test2 = zoo.FindAvailableEnclosure(turtle);
            zoo.FindAvailableEnclosure(turtle).AddAnimals(turtle);

            Assert.Equal(test1, test2);

            Assert.Equal(true, turtle.IsSick());

            zoo.FeedAnimals(DateTime.Now);
            zoo.HealAnimals();

            Assert.Equal(false, turtle.IsSick());
        }
    }
}
