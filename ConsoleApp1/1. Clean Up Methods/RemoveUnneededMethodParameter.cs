using System;
using System.Collections.Generic;
using System.IO;

namespace CleanUpMethods
{
    public class RemoveUnneededMethodParameter
    {
        class Student
        {
            public string name { get; set; }
            public string HomeAddress { get; set; }
            public string country { get; set; }
            public void SaveHomeAddress()
            {
                //Implmentation
            }

        }
        public RemoveUnneededMethodParameter(string name, string homeAddress, string country, string email, string telephone, string fileLocation)
        {
            Student student = new Student() { name="Ahmed",HomeAddress="Cairo",country="Cairo" };
            student.SaveHomeAddress();


            SaveHomeAddress(name, homeAddress, email, country, fileLocation, null);
        }

        public void SaveHomeAddress(string name, string homeAddress, string country,
            string email, string fileLocation, Student student)
        {

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(homeAddress)
                || string.IsNullOrEmpty(fileLocation))
            {
                Console.WriteLine("Input parameters are empty");
            }
            else
            {
                using FileStream fileStream = new FileStream(fileLocation, FileMode.Append);
                using StreamWriter writer = new StreamWriter(fileStream);
                List<string> aPersonRecod = new List<string>
                {
                    name,
                    homeAddress,
                    country,
                    email
                };
                writer.WriteLine(aPersonRecod);
            }
        }
    }
}
