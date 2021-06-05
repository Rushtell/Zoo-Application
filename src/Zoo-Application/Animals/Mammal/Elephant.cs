using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Application
{
    public class Elephant : Mammal
    {
        public Elephant()
        {
            requiredSpaceSqFt = 1000;
            friendlyAnimals.Add(typeof(Bison).ToString());
            friendlyAnimals.Add(typeof(Parrot).ToString());
            friendlyAnimals.Add(typeof(Turtle).ToString());
            friendlyAnimals.Add(typeof(Elephant).ToString());
        }

        public override string FavoriteFood()
        {
            return favoriteFood;
        }

        public override bool IsFriendlyWith(string animal)
        {
            foreach (var item in friendlyAnimals)
            {
                if (item == animal) return true;
            }
            return false;
        }

        public override int RequiredSpaceSqFt()
        {
            return requiredSpaceSqFt;
        }
    }
}
