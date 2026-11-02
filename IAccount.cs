using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6._6
{
    internal interface IAccount
    {
        decimal Balance { get; }
        decimal InterestRate { get; }

        void Deposit(decimal amount);
        bool Withdraw(decimal amount);
    }
}
