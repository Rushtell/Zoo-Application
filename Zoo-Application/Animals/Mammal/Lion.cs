using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Application
{
    public class Lion : Mammal
    {
        public Lion()
        {
            requiredSpaceSqFt = 1000;
            friendlyAnimals.Add("Lion");
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
