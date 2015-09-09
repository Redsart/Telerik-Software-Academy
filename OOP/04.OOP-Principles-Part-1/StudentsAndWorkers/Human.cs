using System;

namespace StudentsAndWorkers
{
    public abstract class Human
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name cant be null or empty.");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name cant be null or empty.");
                }
                this.lastName = value;
            }
        }

        public Human(string fName, string lName)
        {
            this.FirstName = fName;
            this.LastName = lName;
        }
    }
}
