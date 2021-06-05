using System;
using System.Collections.Generic;

namespace Zoo_Application
{
    public class ZooApp
    {
        private List<Zoo> _zoos = new List<Zoo>();

        public void AddZoo(Zoo zoo)
        {
            _zoos.Add(zoo);
        }
    }
}
