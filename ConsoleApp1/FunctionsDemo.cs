using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class FunctionsDemo
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

            public void Register(user user)
            {
                if (notValidforRegister(user))
                    FailNotfiy();
                RegisterNewEmployee(user);

            }

            private static bool notValidforRegister(user user)
            {
                return !IsValidForRegister(user);
            }

            private static string FailNotfiy()
            {
                return "Thanks for registeration HR will contact you soon!";
            }

            private static string SuccessNotify()
            {
                return "Welcome to our Company!";
            }

            private static void RegisterNewEmployee(user user)
            {
                Account account = new Account()
                {
                    name = user.name,
                    age = user.age,
                    email = user.email,
                    password = "newemployee-" + new Random().Next(1000, 5000).ToString()
                };
                account.SendRegisterEmail();
                account.Save();
                SuccessNotify()
            }

            private static bool IsValidForRegister(user user)
            {
                List<string> neededJobs = new List<string>() { "IT", "Network", "Security", "Testing", "Developing" };

                return user.age >= 23 && user.age <= 40 && neededJobs.Contains(user.jobTitle) && !string.IsNullOrEmpty(user.name);
            }
        }
}
