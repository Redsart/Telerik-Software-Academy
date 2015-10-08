using System;

namespace BankAccounts
{
    public interface IWithdrawable
    {
        void Withdraw(decimal amount);
    }
}
