using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Application
{
    public class Veterinarian : IEmployee
    {
        public int CountAction { get; set; }

        public string AnimalExperience { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public void AddAnimalExperience(string animal)
        {
            AnimalExperience = animal;
        }

        public bool HasAnimalExperience(string animal)
        {

            if (animal == AnimalExperience) return true;
            else return false;
        }

        public bool HealAnimal(Animal animal, IConsole console)
        {
            if (!HasAnimalExperience(animal.GetType().ToString())) throw new NoNeededExperienceException("No Needed Experience Exception");
            console.WriteLine($"{FirstName} {LastName} heal {animal}...");
            animal.sick = false;
            CountAction--;
            return true;
        }
    }
}
