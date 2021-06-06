using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Application
{
    public class Snake : Reptile
    {
        public Snake()
        {
            requiredSpaceSqFt = 2;
            friendlyAnimals.Add(typeof(Snake).ToString());
            favoriteFood[0] = typeof(Meet).ToString();
        }

        public override string[] FavoriteFood()
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
