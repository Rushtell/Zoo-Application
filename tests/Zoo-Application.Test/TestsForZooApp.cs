using System;
using System.Collections.Generic;
using Xunit;

namespace Zoo_Application.Test
{
    public class TestsForZooApp
    {
        [Fact]
        public void TestMainZooShouldSplitAnnimalToEncloser()
        {
            ZooApp zooApp = new ZooApp();

            Zoo zoo = new Zoo("Forest");

            IConsole console = new TestConsole();

            zoo.ConsoleZoo = console;

            zooApp.AddZoo(zoo);

            zoo.AddEnclosure("Enclosure1", 10000);
            zoo.AddEnclosure("Enclosure2", 1000);

            Elephant elephant = new Elephant() { ID = 1, sick = true };
            Turtle turtle = new Turtle() { ID = 2, sick = true };

            var test1 = zoo.FindAvailableEnclosure(elephant);
            zoo.FindAvailableEnclosure(elephant).AddAnimals(elephant);
            var test2 = zoo.FindAvailableEnclosure(turtle);
            zoo.FindAvailableEnclosure(turtle).AddAnimals(turtle);


            Veterinarian veterinarian1 = new Veterinarian() { FirstName = "Karlson", LastName = "Krishin" };
            veterinarian1.AddAnimalExperience(typeof(Elephant).ToString());

            Veterinarian veterinarian2 = new Veterinarian() { FirstName = "Valera", LastName = "Baklagan" };
            veterinarian2.AddAnimalExperience(typeof(Turtle).ToString());

            ZooKeeper zooKeeper1 = new ZooKeeper() { FirstName = "Shkaf", LastName = "Petrov" };
            zooKeeper1.AddAnimalExperience(typeof(Elephant).ToString());

            ZooKeeper zooKeeper2 = new ZooKeeper() { FirstName = "Olen", LastName = "Vasiliev" };
            zooKeeper2.AddAnimalExperience(typeof(Turtle).ToString());

            zoo.HireEmployee(veterinarian1);
            zoo.HireEmployee(veterinarian2);
            zoo.HireEmployee(zooKeeper1);
            zoo.HireEmployee(zooKeeper2);

            Assert.Equal(test1, test2);

            Assert.True(turtle.IsSick());

            zoo.FeedAnimals(DateTime.Now);
            zoo.HealAnimals();

            Assert.True(!turtle.IsSick());

            Parrot parrot = new Parrot() { ID = 3, sick = true };
            Lion lion = new Lion() { ID = 4, sick = true };

            var test3 = zoo.FindAvailableEnclosure(parrot);
            zoo.FindAvailableEnclosure(parrot).AddAnimals(parrot);
            var test4 = zoo.FindAvailableEnclosure(lion);
            zoo.FindAvailableEnclosure(lion).AddAnimals(lion);
        }

        [Fact]
        public void TestMainZooShouldSplitEmployeesToAnimal()
        {
            ZooApp zooApp = new ZooApp();

            Zoo zoo = new Zoo("Forest");

            IConsole console = new TestConsole();

            zoo.ConsoleZoo = console;

            zooApp.AddZoo(zoo);

            zoo.AddEnclosure("Enclosure1", 10000);
            zoo.AddEnclosure("Enclosure2", 1000);


            Elephant elephant = new Elephant() { ID = 1, sick = true };
            Turtle turtle = new Turtle() { ID = 2, sick = true };

            var test1 = zoo.FindAvailableEnclosure(elephant);
            zoo.FindAvailableEnclosure(elephant).AddAnimals(elephant);
            var test2 = zoo.FindAvailableEnclosure(turtle);
            zoo.FindAvailableEnclosure(turtle).AddAnimals(turtle);


            Veterinarian veterinarian1 = new Veterinarian() { FirstName = "Karlson", LastName = "Krishin" };
            veterinarian1.AddAnimalExperience(typeof(Elephant).ToString());

            Veterinarian veterinarian2 = new Veterinarian() { FirstName = "Valera", LastName = "Baklagan" };
            veterinarian2.AddAnimalExperience(typeof(Turtle).ToString());

            ZooKeeper zooKeeper1 = new ZooKeeper() { FirstName = "Shkaf", LastName = "Petrov" };
            zooKeeper1.AddAnimalExperience(typeof(Elephant).ToString());

            ZooKeeper zooKeeper2 = new ZooKeeper() { FirstName = "Olen", LastName = "Vasiliev" };
            zooKeeper2.AddAnimalExperience(typeof(Turtle).ToString());



            zoo.HireEmployee(veterinarian1);
            zoo.HireEmployee(veterinarian2);
            zoo.HireEmployee(zooKeeper1);
            zoo.HireEmployee(zooKeeper2);

            zoo.FeedAnimals(DateTime.Now);
            zoo.HealAnimals();

            Parrot parrot = new Parrot() { ID = 3, sick = true };
            Lion lion = new Lion() { ID = 4, sick = true };

            var test3 = zoo.FindAvailableEnclosure(parrot);
            zoo.FindAvailableEnclosure(parrot).AddAnimals(parrot);
            var test4 = zoo.FindAvailableEnclosure(lion);
            zoo.FindAvailableEnclosure(lion).AddAnimals(lion);

            Elephant elephant2 = new Elephant() { ID = 5, sick = true };
            Turtle turtle2 = new Turtle() { ID = 6, sick = true };

            var test5 = zoo.FindAvailableEnclosure(elephant2);
            zoo.FindAvailableEnclosure(elephant2).AddAnimals(elephant2);
            var test6 = zoo.FindAvailableEnclosure(turtle2);
            zoo.FindAvailableEnclosure(turtle2).AddAnimals(turtle2);


            Veterinarian veterinarian3 = new Veterinarian() { FirstName = "Karlson", LastName = "Krishin" };
            veterinarian3.AddAnimalExperience(typeof(Elephant).ToString());

            Veterinarian veterinarian4 = new Veterinarian() { FirstName = "Valera", LastName = "Baklagan" };
            veterinarian4.AddAnimalExperience(typeof(Turtle).ToString());

            ZooKeeper zooKeeper3 = new ZooKeeper() { FirstName = "Shkaf", LastName = "Petrov" };
            zooKeeper3.AddAnimalExperience(typeof(Elephant).ToString());

            ZooKeeper zooKeeper4 = new ZooKeeper() { FirstName = "Olen", LastName = "Vasiliev" };
            zooKeeper4.AddAnimalExperience(typeof(Turtle).ToString());

            zoo.HireEmployee(veterinarian3);
            zoo.HireEmployee(veterinarian4);
            zoo.HireEmployee(zooKeeper3);
            zoo.HireEmployee(zooKeeper4);

            zoo.FeedAnimals(DateTime.Now);
            zoo.HealAnimals();

            zoo.FillCount();
            Assert.Equal(1, zoo.Employees[2].CountAction);
            Assert.Equal(1, zoo.Employees[6].CountAction);

            Assert.True(zoo.Enclosures[0].Animals[0].FeedTimes()[0].FeedByZooKeeper == zoo.Enclosures[0].Animals[0].FeedTimes()[1].FeedByZooKeeper);
            Assert.True(zoo.Enclosures[0].Animals[0].FeedTimes()[1].FeedByZooKeeper != zoo.Enclosures[0].Animals[3].FeedTimes()[0].FeedByZooKeeper);
        }
    }

    public class TestConsole : IConsole
    {
        List<string> ConsoleLog = new List<string>();

        public void Write(string msg)
        {
            ConsoleLog.Add($"{msg}");
        }

        public void WriteLine(string msg)
        {
            ConsoleLog.Add($"\n{msg}");
        }
    }


}
