using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Application
{
    public class HireValidatorProvider : IHireValidator
    {
        public List<string> ValidateEmployee(IEmployee employee)
        {
            Type type = employee.GetType();
            if (type == typeof(Veterinarian))
            {
                VeterinarianHireValidator veterinarianHireValidator = new VeterinarianHireValidator();
                return veterinarianHireValidator.ValidateEmployee(employee);
            }
            else if (type == typeof(ZooKeeper))
            {
                ZooKeeperHireValidator zooKeeperHireValidator = new ZooKeeperHireValidator();
                return zooKeeperHireValidator.ValidateEmployee(employee);
            }
            else throw new Exception();
        }
    }
}
