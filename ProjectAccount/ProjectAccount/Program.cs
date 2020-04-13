using System;
using System.Globalization;
using System.Collections.Generic;
using ProjectAccount.Entities;
using ProjectAccount.Entities.Exceptions;

namespace ProjectAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Account> accounts = new List<Account>();

                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                accounts.Add(new Account(number, holder, balance, limit));

                Console.Write("\nEnter amount for withdraw: ");
                double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                accounts[0].withdraw(withdraw);
                Console.WriteLine("New balance: " + accounts[0].Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (AccountException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
        }
    }
}
