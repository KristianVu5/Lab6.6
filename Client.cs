using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6._6
{
    internal class Client : IAccount
    {
        public decimal Balance { get; private set; }
        public decimal InterestRate { get; }
        public Client(decimal initialBalance, decimal interestRate)
        {
            if (initialBalance < 0)
                throw new ArgumentOutOfRangeException(nameof(initialBalance));

            if (interestRate < 0)
                throw new ArgumentOutOfRangeException(nameof(interestRate));
            Balance = initialBalance;
            InterestRate = interestRate;
        }
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive.");
            }
            Balance += amount;
        }
        public bool Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be positive.");
            }
            if (amount > Balance)
            { 
                return false;
            }
            Balance -= amount;
            return true;
        }
    }
}
