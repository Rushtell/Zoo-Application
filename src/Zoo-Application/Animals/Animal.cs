using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Zoo_Application
{
    public abstract class Animal
    {
        public int ID { get; set; }

        public int requiredSpaceSqFt { get; set; }

        public string[] favoriteFood { get; set; } = new string[1];

        public List<FeedTime> feedTimes = new List<FeedTime>();

        public List<int> feedSchedule = new List<int>();

        public bool sick { get; set; }

        public List<string> friendlyAnimals = new List<string>();


        public abstract int RequiredSpaceSqFt();

        public abstract string [] FavoriteFood();

        public List<FeedTime> FeedTimes()
        {
            return feedTimes;
        }

        public List<int> FeedSchedule()
        {
            return feedSchedule;
        }

        public bool IsSick()
        {
            return sick;
        }

        public abstract bool IsFriendlyWith(string animal);

        public void Feed(Food food)
        {
            if (Type.GetType(favoriteFood[0]) == food.GetType()) Console.WriteLine("Mmmm, hrum-hrum-hrum");
            else Console.WriteLine("Hrum-hrum");
        }

        public void AddFeedSchedule(List<int> hours)
        {
            feedSchedule = hours;
        }

        public void Heal (Medicine medicine)
        {
            sick = false;
        }
    }
}
