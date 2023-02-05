﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CleanCodeDemo
    {
        int exchangeRate;

        public bool isEmployeesNamesValid(List<string> employeeNames)
        {
            bool allEmployeesValid = true;
            foreach (var employeeName in employeeNames)
            {
                if (allEmployeesValid)
                {
                    if (this.isValid(employeeName))
                    {
                        allEmployeesValid = false;
                    }
                }
            }
            return allEmployeesValid;
        }
        private bool isValid(string employeeName)
        {
            return string.IsNullOrEmpty(employeeName);
        }

        public bool CheckIfCreditCanBeApproved(int amount, int age, int creditDuration)
        {
            //These are conditions where credit can be approved - allowed risk
            if (NewMethod(amount, age, creditDuration))
            {
                return true;
            }
            //other logic here....
            return false;
        }

        private static bool NewMethod(int amount, int age, int creditDuration)
        {
            return amount < 100000 || (age < 65 && creditDuration < 15);
        }
    }
}
