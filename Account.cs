using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BankManagementSystem
{
    public class Account
    {
        public static void CreateAccount()
        {
            String name;
            String surname;
            String id;
            int pin;
            double balance = 50.0;
            Console.WriteLine("****CREATE ACCOUNT*******");

            Console.WriteLine("Enter your name : ");
            name = Console.ReadLine();
            Console.WriteLine("Enter your surname : ");
            surname = Console.ReadLine();
            Console.WriteLine("Enter your ID number : ");
            id = Console.ReadLine();
            Console.WriteLine("Create a 4 digit pin number");
            pin = Convert.ToInt32(Console.ReadLine());

            // Generate and display a random 10-digit number
            long random10DigitNumber = GenerateRandom10DigitNumber();
            Console.WriteLine("Your account number is " + random10DigitNumber);
        }

        static long GenerateRandom10DigitNumber()
        {
            Random random = new Random();

            // Generate a random double between 0 and 1
            double randomDouble = random.NextDouble();

            // Scale the double to the desired range for a 10-digit number
            long result = (long)(randomDouble * (9999999999 - 1000000000 + 1) + 1000000000);

            return result;
          
        }
    }
}

