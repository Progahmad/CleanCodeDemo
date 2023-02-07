using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Employee
    {
        public int id;
        public string name;
        public int age;
       // public int salary;
        private int salary;

        public int Salary
        {
            get { return salary; }
            set {
                //Business Role
                int MinSalary = 10000;
                if (value >= MinSalary)
                    salary = value;
                else
                    throw new Exception("Salary Should be Greater than " + MinSalary);

            }
        }

    }
    public class Manager : Employee
    {
        
    }    
}
