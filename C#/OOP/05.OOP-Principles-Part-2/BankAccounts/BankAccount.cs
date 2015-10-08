using System;

namespace BankAccounts
{
    public abstract class BankAccount : IDepositable
    {
        private decimal balance;
        private decimal interestRate;

        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            protected set
            {
                if (value<0)
                {
                    throw new ArgumentException("Balance must be > 0.");
                }
                this.balance = value;
            }
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }
            private set
            {
                if (value<0)
                {
                    throw new ArgumentException("Interest must be > 0.");
                }
                this.interestRate = value;
            }
        }

        public Customer Customer
        {
            get;
            private set;
        }

        protected BankAccount(decimal balance, decimal interest, Customer customer)
        {
            this.Balance = balance;
            this.InterestRate = interest;
            this.Customer = customer;
        }

        public virtual decimal CalculateInterest(int months)
        {
            return this.Balance * (this.InterestRate / 100) * months;
        }

        public abstract void Deposit(decimal amount);
    }    
}
