using System;
using System.Collections.Generic;
using System.IO;

namespace CleanUpConditionals
{
    public class SimplifyIfStatements
    {
        public void SaveHomeAddress(string name, string homeAddress, string country, string email, string fileLocation)
        {

            if (IsEmptyorNull(name, homeAddress, fileLocation))
            {
                Console.WriteLine("Input parameters are empty");
            }
            else
            {
                SaveFile(name, homeAddress, country, email, fileLocation);
            }
        }

        private static void SaveFile(string name, string homeAddress, string country, string email, string fileLocation)
        {
            using (FileStream fileStream = new FileStream(fileLocation, FileMode.Append))
            using (StreamWriter writer = new StreamWriter(fileStream))
            {
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

        private static bool IsEmptyorNull(string name, string homeAddress, string fileLocation)
        {
            return string.IsNullOrEmpty(name) || string.IsNullOrEmpty(homeAddress)
                                        || string.IsNullOrEmpty(fileLocation);
        }
    }
}
