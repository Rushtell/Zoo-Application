﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Application
{
    public class ZooKeeperHireValidator : HireValidator
    {
        public override List<string> ValidateEmployee(IEmployee employee, Zoo zoo)
        {
            if (employee.FirstName == null)
            {
                ValidationErrors.Add("FirstName cant be null");
                return ValidationErrors;
            }
            if (employee.LastName == null)
            {
                ValidationErrors.Add("LastName cant be null");
                return ValidationErrors;
            }
            if (employee.FirstName.Length < 3 || employee.FirstName.Length > 50) ValidationErrors.Add("Length FirstName incorrect");
            if (employee.LastName.Length < 3 || employee.LastName.Length > 50) ValidationErrors.Add("Length LastName incorrect");
            if (!FindExp(employee.AnimalExperience, zoo)) ValidationErrors.Add("No Needed Experience");
            return ValidationErrors;
        }

        private bool FindExp(string typeAnimal, Zoo zoo)
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
