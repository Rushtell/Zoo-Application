using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Application
{
    public class Parrot : Bird
    {
        public Parrot()
        {
            requiredSpaceSqFt = 5;
            friendlyAnimals.Add(typeof(Elephant).ToString());
            friendlyAnimals.Add(typeof(Parrot).ToString());
            friendlyAnimals.Add(typeof(Bison).ToString());
            friendlyAnimals.Add(typeof(Turtle).ToString());
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
