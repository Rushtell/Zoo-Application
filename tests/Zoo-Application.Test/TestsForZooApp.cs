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

            IConsole console = new TestConsole();

            Zoo zoo = new Zoo("Forest", console);

            zooApp.AddZoo(zoo);

            zoo.AddEnclosure("Enclosure1", 10000);
            zoo.AddEnclosure("Enclosure2", 1000);
            zoo.AddEnclosure("Enclosure3", 10000);
            zoo.AddEnclosure("Enclosure4", 1000);
            zoo.AddEnclosure("Enclosure5", 10000);
            zoo.AddEnclosure("Enclosure6", 1000);

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

            Bison bison = new Bison() { ID = 5, sick = true };
            Snake snake = new Snake() { ID = 6, sick = true };

            zoo.FindAvailableEnclosure(bison).AddAnimals(bison);
            zoo.FindAvailableEnclosure(snake).AddAnimals(snake);

            Penguin penguin = new Penguin() { ID = 7, sick = true };
            Penguin penguin2 = new Penguin() { ID = 7, sick = true };
            Lion lion2 = new Lion() { ID = 8, sick = true };

            zoo.FindAvailableEnclosure(penguin).AddAnimals(penguin);
            zoo.FindAvailableEnclosure(penguin2).AddAnimals(penguin2);
            zoo.FindAvailableEnclosure(lion2).AddAnimals(lion2);

            Veterinarian veterinarian3 = new Veterinarian() { FirstName = "Karlson", LastName = "Krishin" };
            veterinarian3.AddAnimalExperience(typeof(Parrot).ToString());

            Veterinarian veterinarian4 = new Veterinarian() { FirstName = "Valera", LastName = "Baklagan" };
            veterinarian4.AddAnimalExperience(typeof(Penguin).ToString());

            ZooKeeper zooKeeper3 = new ZooKeeper() { FirstName = "Shkaf", LastName = "Petrov" };
            zooKeeper3.AddAnimalExperience(typeof(Parrot).ToString());

            ZooKeeper zooKeeper4 = new ZooKeeper() { FirstName = "Olen", LastName = "Vasiliev" };
            zooKeeper4.AddAnimalExperience(typeof(Penguin).ToString());

            Veterinarian veterinarian5 = new Veterinarian() { FirstName = "Karlson", LastName = "Krishin" };
            veterinarian5.AddAnimalExperience(typeof(Bison).ToString());

            Veterinarian veterinarian6 = new Veterinarian() { FirstName = "Valera", LastName = "Baklagan" };
            veterinarian6.AddAnimalExperience(typeof(Lion).ToString());

            ZooKeeper zooKeeper5 = new ZooKeeper() { FirstName = "Shkaf", LastName = "Petrov" };
            zooKeeper5.AddAnimalExperience(typeof(Bison).ToString());

            ZooKeeper zooKeeper6 = new ZooKeeper() { FirstName = "Olen", LastName = "Vasiliev" };
            zooKeeper6.AddAnimalExperience(typeof(Lion).ToString());

            Veterinarian veterinarian7 = new Veterinarian() { FirstName = "Valera", LastName = "Baklagan" };
            veterinarian7.AddAnimalExperience(typeof(Snake).ToString());

            ZooKeeper zooKeeper7 = new ZooKeeper() { FirstName = "Olen", LastName = "Vasiliev" };
            zooKeeper7.AddAnimalExperience(typeof(Snake).ToString());

            zoo.HireEmployee(veterinarian3);
            zoo.HireEmployee(veterinarian4);
            zoo.HireEmployee(veterinarian5);
            zoo.HireEmployee(veterinarian6);
            zoo.HireEmployee(veterinarian7);
            zoo.HireEmployee(zooKeeper3);
            zoo.HireEmployee(zooKeeper4);
            zoo.HireEmployee(zooKeeper5);
            zoo.HireEmployee(zooKeeper6);
            zoo.HireEmployee(zooKeeper7);

            zoo.FeedAnimals(DateTime.Now);
            zoo.HealAnimals();
        }

        [Fact]
        public void TestMainZooShouldSplitEmployeesToAnimal()
        {
            ZooApp zooApp = new ZooApp();

            IConsole console = new TestConsole();

            Zoo zoo = new Zoo("Forest", console);


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

        [Fact]
        public void TestExceptions()
        {
            Assert.Throws<NoAvailableEclosureException> ( () => 
            {
                ZooApp zooApp = new ZooApp();
                IConsole console = new TestConsole();
                Zoo zoo = new Zoo("Forest", console);
                zooApp.AddZoo(zoo);
                Elephant elephant = new Elephant() { ID = 1, sick = true };
                Turtle turtle = new Turtle() { ID = 2, sick = true };
                var test1 = zoo.FindAvailableEnclosure(elephant);
            });

            Assert.Throws<NotFriendlyAnimalException>(() =>
            {
                ZooApp zooApp = new ZooApp();
                IConsole console = new TestConsole();
                Zoo zoo = new Zoo("Forest", console);
                zooApp.AddZoo(zoo);
                zoo.AddEnclosure("Enclosure1", 10000);
                Elephant elephant = new Elephant() { ID = 1, sick = true };
                Lion lion = new Lion() { ID = 2, sick = true };
                zoo.FindAvailableEnclosure(elephant).AddAnimals(elephant);
                zoo.Enclosures[0].AddAnimals(lion);
            });

            Assert.Throws<NoNeededExperienceException>(() =>
            {
                ZooApp zooApp = new ZooApp();

                IConsole console = new TestConsole();

                Zoo zoo = new Zoo("Forest", console);

                zooApp.AddZoo(zoo);

                zoo.AddEnclosure("Enclosure1", 10000);

                Veterinarian veterinarian1 = new Veterinarian() { FirstName = "Karlson", LastName = "Krishin" };
                veterinarian1.AddAnimalExperience(typeof(Lion).ToString());

                zoo.HireEmployee(veterinarian1);
            });

            Assert.Throws<NoAvailableSpaceException>(() =>
            {
                ZooApp zooApp = new ZooApp();

                IConsole console = new TestConsole();

                Zoo zoo = new Zoo("Forest", console);


                zoo.ConsoleZoo = console;

                zooApp.AddZoo(zoo);

                zoo.AddEnclosure("Enclosure1", 100);

                Elephant elephant = new Elephant() { ID = 1, sick = true };

                zoo.Enclosures[0].AddAnimals(elephant);
            });

            Assert.Throws<NoNeededExperienceException>(() =>
            {
                ZooApp zooApp = new ZooApp();

                IConsole console = new TestConsole();

                Zoo zoo = new Zoo("Forest", console);

                zooApp.AddZoo(zoo);

                zoo.AddEnclosure("Enclosure1", 10000);

                Veterinarian veterinarian1 = new Veterinarian() { LastName = "Krishin" };
                veterinarian1.AddAnimalExperience(typeof(Lion).ToString());

                zoo.HireEmployee(veterinarian1);
            });

            Assert.Throws<NoNeededExperienceException>(() =>
            {
                ZooApp zooApp = new ZooApp();

                IConsole console = new TestConsole();

                Zoo zoo = new Zoo("Forest", console);

                zooApp.AddZoo(zoo);

                zoo.AddEnclosure("Enclosure1", 10000);

                Veterinarian veterinarian1 = new Veterinarian() { FirstName = "Krishin" };
                veterinarian1.AddAnimalExperience(typeof(Lion).ToString());

                zoo.HireEmployee(veterinarian1);
            });

            Assert.Throws<NoNeededExperienceException>(() =>
            {
                ZooApp zooApp = new ZooApp();

                IConsole console = new TestConsole();

                Zoo zoo = new Zoo("Forest", console);

                zooApp.AddZoo(zoo);

                zoo.AddEnclosure("Enclosure1", 10000);

                ZooKeeper zooKeeper = new ZooKeeper() { LastName = "Krishin" };
                zooKeeper.AddAnimalExperience(typeof(Lion).ToString());

                zoo.HireEmployee(zooKeeper);
            });

            Assert.Throws<NoNeededExperienceException>(() =>
            {
                ZooApp zooApp = new ZooApp();

                IConsole console = new TestConsole();

                Zoo zoo = new Zoo("Forest", console);

                zooApp.AddZoo(zoo);

                zoo.AddEnclosure("Enclosure1", 10000);

                ZooKeeper zooKeeper = new ZooKeeper() { FirstName = "Krishin" };
                zooKeeper.AddAnimalExperience(typeof(Lion).ToString());

                zoo.HireEmployee(zooKeeper);
            });
        }

        [Fact]
        public void TestAnimalClass()
        {
            List<int> feedScheduleTest = new List<int>() { 8, 20 };

            Elephant test = new Elephant() { ID = 1};
            test.AddFeedSchedule(feedScheduleTest);
            var test2 = test.FeedSchedule();

            Assert.Equal(feedScheduleTest, test2);
        }

        [Fact]
        public void ShouldNotFriendlyPenguinsAndLions()
        {
            ZooApp zooApp = new ZooApp();
            IConsole console = new TestConsole();
            Zoo zoo = new Zoo("Forest", console);
            zooApp.AddZoo(zoo);
            zoo.AddEnclosure("Enclosure1", 10000);
            zoo.AddEnclosure("Enclosure2", 10000);
            zoo.AddEnclosure("Enclosure3", 10000);
            Lion lion = new Lion() { ID = 1, sick = true };
            Penguin penguin = new Penguin() { ID = 2, sick = true };
            Bison bison = new Bison() { ID = 3, sick = true };

            zoo.FindAvailableEnclosure(lion).AddAnimals(lion);
            zoo.FindAvailableEnclosure(penguin).AddAnimals(penguin);
            zoo.FindAvailableEnclosure(bison).AddAnimals(bison);
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
