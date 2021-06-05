using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Application
{
    public class NoNeededExperienceException : Exception
    {
        public NoNeededExperienceException(string msg) : base(msg) { }
    }
}
