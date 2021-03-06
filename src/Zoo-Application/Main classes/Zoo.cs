using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Application
{
    public class Zoo
    {
        public IConsole ConsoleZoo { get; set; }

        public List<Enclosure> Enclosures { get; set; } = new List<Enclosure>();

        public List<IEmployee> Employees { get; set; } = new List<IEmployee>();

        public string Location { get; set; }

        public Zoo(string location, IConsole console)
        {
            Location = location;
            ConsoleZoo = console;
            ConsoleZoo.Write($"Added new zoo in {location}");
        }

        public Enclosure AddEnclosure(string name, int squreFeet)
        {
            ConsoleZoo.WriteLine($"Add Enclosure name: {name} squre feet: {squreFeet}...");
            Enclosure enclosure = new Enclosure() { Name = name, ParentZoo = this, SqureFeet = squreFeet };
            Enclosures.Add(enclosure);
            return enclosure;
        }

        public Enclosure FindAvailableEnclosure(Animal animal)
        {
            ConsoleZoo.WriteLine($"Find Available Enclosure for animal...");
            if (Enclosures.Count == 0) throw new NoAvailableEclosureException("NoAvailableEclosureException");
            foreach (var enclosur in Enclosures)
            {
                bool skip = false;
                int tempSq = enclosur.SqureFeet;
                foreach (var item in enclosur.Animals)
                {
                    tempSq -= item.RequiredSpaceSqFt();
                }
                if ((tempSq - animal.RequiredSpaceSqFt()) >= 0)
                {
                    foreach (var item in enclosur.Animals)
                    {
                        if (!item.IsFriendlyWith(animal.GetType().ToString())) skip = true;
                    }
                    if (skip) continue;
                    return enclosur;
                }
            }
            throw new NoAvailableEclosureException("NoAvailableEclosureException");
        }

        public void HireEmployee(IEmployee employee)
        {
            ConsoleZoo.WriteLine($"Try Hire Employee...");
            HireValidatorProvider hireValidatorProvider = new HireValidatorProvider();

            List<string> ErrorsValidate = hireValidatorProvider.ValidateEmployee(employee, this, ConsoleZoo);

            if (ErrorsValidate.Count > 0)
            {
                ConsoleZoo.WriteLine($"Ooops, hire is fall:");
                foreach (var item in ErrorsValidate)
                {
                    ConsoleZoo.WriteLine($"{item}");
                }
                throw new NoNeededExperienceException(ErrorsValidate[0]);
            }

            Employees.Add(employee);
        }

        public void FeedAnimals(DateTime time)
        {
            ConsoleZoo.WriteLine($"Start feed animals...");
            FillCount();
            foreach (var enclosure in Enclosures)
            {
                foreach (var animal in enclosure.Animals)
                {
                    foreach (var employee in Employees)
                    {
                        if (employee.GetType() == typeof(ZooKeeper))
                        {
                            if (((ZooKeeper)employee).HasAnimalExperience(animal.GetType().ToString()))
                            {
                                if (employee.CountAction != 0)
                                {
                                    ((ZooKeeper)employee).FeedAnimal(animal, time, ConsoleZoo);
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }

        public void HealAnimals()
        {
            FillCount();
            foreach (var enclosure in Enclosures)
            {
                foreach (var animal in enclosure.Animals)
                {
                    if (animal.IsSick())
                    {
                        foreach (var employee in Employees)
                        {
                            if (employee.GetType() == typeof(Veterinarian))
                            {
                                if (((Veterinarian)employee).HasAnimalExperience(animal.GetType().ToString()))
                                {
                                    if (employee.CountAction != 0)
                                    {
                                        ((Veterinarian)employee).HealAnimal(animal, ConsoleZoo);
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public void FillCount()
        {
            foreach (var employee in Employees)
            {
                int tempCountAction = -1;
                double tempCountAnimal = 0;
                double tempCountEmployee = 0;
                foreach (var enclosure in Enclosures)
                {
                    foreach (var animal in enclosure.Animals)
                    {
                        if (animal.GetType().ToString() == employee.AnimalExperience) tempCountAnimal++;
                    }
                }
                foreach (var employee2 in Employees)
                {
                    if (employee2.AnimalExperience == employee.AnimalExperience) tempCountEmployee++;
                }
                if (tempCountEmployee > 1) tempCountAction = Convert.ToInt32(Math.Ceiling(tempCountAnimal / tempCountEmployee));

                employee.CountAction = tempCountAction;
            }
        }
    }
}
