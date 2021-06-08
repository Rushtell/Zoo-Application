using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Application
{
    public class HireValidatorProvider : IHireValidator
    {
        public List<string> ValidateEmployee(IEmployee employee, Zoo zoo, IConsole console)
        {
            Type type = employee.GetType();
            if (type == typeof(Veterinarian))
            {
                VeterinarianHireValidator veterinarianHireValidator = new VeterinarianHireValidator();
                return veterinarianHireValidator.ValidateEmployee(employee, zoo, console);
            }
            else if (type == typeof(ZooKeeper))
            {
                ZooKeeperHireValidator zooKeeperHireValidator = new ZooKeeperHireValidator();
                return zooKeeperHireValidator.ValidateEmployee(employee, zoo, console);
            }
            else throw new Exception();
        }
    }
}
