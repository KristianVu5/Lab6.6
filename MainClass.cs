using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6._6
{
    internal class MainClass
    {
        static void Main(string[] args)
        {
            IAccount account = new Client(1000m, 0.03m);

            Console.WriteLine($"Initial Balance: {account.Balance:F2} eur.");
            Console.WriteLine($"Interest Rate: {account.InterestRate:P}");

            account.Deposit(250m);
            Console.WriteLine($"Balance after deposit: {account.Balance:F2} eur.");

            if(account.Withdraw(100m))
            {
                Console.WriteLine($"Balance after withdrawal: {account.Balance:F2} eur.");
            }
            else
            {
                Console.WriteLine("Withdrawal failed due to insufficient funds.");
            }

            if (!account.Withdraw(5000m))
            {
                Console.WriteLine("Withdraw of 5000 eur failed due to insufficient funds.");
            }
        }

    }
}
