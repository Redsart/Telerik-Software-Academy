using System;

namespace BankAccounts
{
    public class MortgageAccount : BankAccount, IDepositable
    {
        public MortgageAccount(decimal balance, decimal interest, Customer customer) : base(balance, interest, customer)
        {

        }

        public override void Deposit(decimal amount)
        {
            if (amount<0)
            {
                throw new ArgumentException("Deposit amount cannot be negative.");
            }
            if (this.Balance>amount)
            {
                this.Balance -= amount;
            }
            this.Balance = 0;
        }

        public override decimal CalculateInterest(int months)
        {
            if (months<0)
            {
                throw new ArgumentException("Months cannot be < 0.");
            }
            if (Customer is Individual)
            {
                if (months<=6)
                {
                    return 0;
                }
                return (this.Balance * (this.InterestRate / 100) * (months-6));
            }

            if (months<=12)
            {
                return (this.Balance * (this.InterestRate / 100) * months) / 2;
            }
            return this.Balance * (this.InterestRate / 100) * (months - 12)+(this.Balance*(this.InterestRate/100)*6);
        }
    }
}
