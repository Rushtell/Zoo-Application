using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Application
{
    public class Penguin : Bird
    {
        public Penguin()
        {
            requiredSpaceSqFt = 10;
            friendlyAnimals.Add(typeof(Penguin).ToString());
            favoriteFood[0] = typeof(Vegetable).ToString();

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
