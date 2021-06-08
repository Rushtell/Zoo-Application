using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Application
{
    public class VeterinarianHireValidator : HireValidator
    {
        public override List<string> ValidateEmployee(IEmployee employee, Zoo zoo, IConsole console)
        {
            if(employee.FirstName == null)
            {
                console.WriteLine("FirstName cant be null");
                ValidationErrors.Add("FirstName cant be null");
                return ValidationErrors;
            }
            if (employee.LastName == null)
            {
                console.WriteLine("LastName cant be null");
                ValidationErrors.Add("LastName cant be null");
                return ValidationErrors;
            }
            if (employee.FirstName.Length < 3 || employee.FirstName.Length > 50)
            {
                console.WriteLine("Length FirstName incorrect");
                ValidationErrors.Add("Length FirstName incorrect");
            }
            if (employee.LastName.Length < 3 || employee.LastName.Length > 50)
            {
                console.WriteLine("Length LastName incorrect");
                ValidationErrors.Add("Length LastName incorrect");
            }
            if (!FindExp(employee.AnimalExperience, zoo, console)) 
            {
                console.WriteLine("Length LastName incorrect");
                ValidationErrors.Add("No Needed Experience");
            } 
            return ValidationErrors;
        }

        private bool FindExp (string typeAnimal, Zoo zoo, IConsole console)
        {
            foreach (var enclosur in zoo.Enclosures)
            {
                foreach (var animal in enclosur.Animals)
                {
                    if (animal.GetType().ToString() == typeAnimal) return true;
                }
            }
            return false;
        }
    }
}
