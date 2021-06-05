﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Application
{
    public class ZooKeeper : IEmployee
    {
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

        public bool FeedAnimal (Animal animal, DateTime time)
        {
            if (!HasAnimalExperience(animal.GetType().ToString())) throw new NoNeededExperienceException("No Needed Experience Exception");
            animal.feedTimes.Add(new FeedTime() { FeedByZooKeeper = this, _FeedTime = time });
            animal.FavoriteFood();
            return true;
        }
    }
}