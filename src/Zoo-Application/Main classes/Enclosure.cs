using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Application
{
    public class Enclosure
    {
        public string Name { get; set; }

        public List<Animal> Animals { get; set; } = new List<Animal>();

        public Zoo ParentZoo { get; set; }

        public int SqureFeet { get; set; }

        public void AddAnimals(Animal animal)
        {
            int tempSq = SqureFeet;
            foreach (var animalItem in Animals)
            {
                tempSq -= animalItem.RequiredSpaceSqFt();
            }
            if (tempSq < animal.RequiredSpaceSqFt()) throw new NoAvailableSpaceException("NoAvailableSpaceException");
            Animals.Add(animal);
        }
    }
}
