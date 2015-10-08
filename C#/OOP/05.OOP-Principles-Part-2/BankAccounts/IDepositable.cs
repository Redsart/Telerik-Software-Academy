using System;

namespace BankAccounts
{
    public interface IDepositable
    {
        void Deposit(decimal amount);
    }
}
