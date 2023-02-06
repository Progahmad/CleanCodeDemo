using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.CleanCodeDemo;

namespace ConsoleApp1
{
    internal class CleanCodeDemo
    {
        public class user
        {
            public string name;
            public int age;
            public string email;

            public string jobTitle;
        }
        public class Account
        {
            
            public string name;
            public int age;
            public string jobTitle;
            public string email;
            public string password;
            public void Save()
            {
                Console.WriteLine("Data Save to DB Successfully");
            }
            public void SendRegisterEmail()
            {
                Console.WriteLine("Email Save to DB Successfully");
            }
        }
        private int firstName;

        public int FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string Register(user user)
        {
            if (IsNotValidforRegister(user))
                return SendNotAcceptedView();
            CreateAccount(user);
            return SendSuccessView();

        }

        private static bool IsNotValidforRegister(user user)
        {
            return !IsValidforRegister(user);
        }

        private static string SendNotAcceptedView()
        {
            return "Thanks for registeration HR will contact you soon!";
        }

        private static string SendSuccessView()
        {
            return "Welcome to our Company!";
        }

        private static void SendRegisterationNotificationEmail(Account account)
        {
            account.SendRegisterEmail();
            account.Save();
        }

        private static Account CreateAccount(user user)
        {
            return new Account()
            {
                name = user.name,
                age = user.age,
                email = user.email,
                password = "newemployee-" + new Random().Next(1000, 5000).ToString()
            };
            SendRegisterationNotificationEmail(account);

        }

        private static List<string> getNeededJobs()
        {
            return new List<string>() { "IT", "Network", "Security", "Testing", "Developing" };
        }

        private static bool IsValidforRegister(user user)
        {
            neededJobs = getNeededJobs();
            return user.age >= 23 && user.age <= 40 && neededJobs.Contains(user.jobTitle) && !string.IsNullOrEmpty(user.name) && !string.IsNullOrEmpty(user.email);
        }

        private const int StatusCode = 211;

        public bool ShouldCloseConnection(int responseCode)
        {
            if (responseCode == StatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        int exchangeRate;

        public bool isEmployeesNamesValid(List<string> employeeNames)
        {
            bool allEmployeesValid = true;
            foreach (var employeeName in employeeNames)
            {
                allEmployeesValid = CheckEmployeeValidName(allEmployeesValid, employeeName);
            }
            return allEmployeesValid;
        }

        private bool CheckEmployeeValidName(bool allEmployeesValid, string employeeName)
        {
            if (allEmployeesValid)
            {
                if (this.isValid(employeeName))
                {
                    allEmployeesValid = false;
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
