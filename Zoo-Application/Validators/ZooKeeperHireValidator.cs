using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Application
{
    public class ZooKeeperHireValidator : HireValidator
    {
        public override List<string> ValidateEmployee(IEmployee employee)
        {
            // Валидация найма работника и внесение ошибок в лист
            return ValidationErrors;
        }
    }
}
