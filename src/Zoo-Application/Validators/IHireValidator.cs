using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Application
{
    public interface IHireValidator
    {
        public List<string> ValidateEmployee(IEmployee employee, Zoo zoo);
    }
}
