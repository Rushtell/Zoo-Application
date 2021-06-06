using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace Zoo_Application
{
    public abstract class HireValidator
    {
        public List<string> ValidationErrors = new List<string>();

        public abstract List<string> ValidateEmployee(IEmployee employee, Zoo zoo);
    }
}
