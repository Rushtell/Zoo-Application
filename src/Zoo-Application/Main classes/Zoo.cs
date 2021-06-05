using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Application
{
    public class Zoo
    {
        public List<Enclosure> Enclosures { get; set; } = new List<Enclosure>();

        public List<IEmployee> Employees { get; set; } = new List<IEmployee>();

        public string Location { get; set; }

        public Zoo(string location)
        {
            Location = location;
        }

        public Enclosure AddEnclosure(string name, int squreFeet)
        {
            Enclosure enclosure = new Enclosure() { Name = name, ParentZoo = this, SqureFeet = squreFeet };
            Enclosures.Add(enclosure);
            return enclosure;
        }

        public Enclosure FindAvailableEnclosure(Animal animal)
        {
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
            HireValidatorProvider hireValidatorProvider = new HireValidatorProvider();

            List<string> ErrorsValidate = hireValidatorProvider.ValidateEmployee(employee);

            if (ErrorsValidate.Count > 0)
            {
                throw new NoNeededExperienceException(ErrorsValidate[0]);
            }

            Employees.Add(employee);
        }

        public void FeedAnimals(DateTime time)
        {
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
                                ((ZooKeeper)employee).FeedAnimal(animal, time);
                            }
                        }
                    }
                }
            }
        }

        public void HealAnimals()
        {
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
                                    ((Veterinarian)employee).HealAnimal(animal);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
