using System;

namespace BankAccounts
{
    public abstract class Customer
    {
        private string name;

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty.");
                }
                this.name = value;
            }
        }

        public string CustomerNumber
        {
            get;
            private set;
        }

        protected Customer(string name, string customerNumber)
        {
            this.Name = name;
            this.CustomerNumber = customerNumber;
        }
    }
}
