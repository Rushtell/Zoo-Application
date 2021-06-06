using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Application
{
    public interface IEmployee
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string AnimalExperience { get; set; }

        public int CountAction { get; set; }
    }
}
