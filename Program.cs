using BankManagementSystem;
using System;
    
public class Program
{
    public static void Main(string[] args)
    {
        int options;

        //welcome the user to the system
        Console.WriteLine("*********************************");
        Console.WriteLine("Welcome to your banking system");
        Console.WriteLine("**********************************");

        //provide options to the user 
       Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Create an account");
            Console.WriteLine("2. Deposit money");
            Console.WriteLine("3. Withdraw money");
            Console.WriteLine("4. Check balance");
            Console.WriteLine("5. Transfer money");
            Console.WriteLine("6. Get statement");
            Console.WriteLine("7. Exit");

        options = Convert.ToInt32(Console.ReadLine());
        

      if (options == 1)

        {
            Account.CreateAccount();
        }
      else if (options == 2)
        {
            Deposit.DepositMoney();
        }
       
        {

        }
    
    }
}
