using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementSystem
{
  public class Deposit
    {
        public static void DepositMoney()
        {
            double amount;
       int balance = 50;
            Console.WriteLine("DEPOSIT");

            Console.WriteLine("Enter amount to deposit");
            amount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Your balance is : " + amount + balance);
        }
    }
}
