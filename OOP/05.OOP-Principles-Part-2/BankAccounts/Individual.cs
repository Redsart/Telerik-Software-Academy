using System;

namespace BankAccounts
{
    public class Individual : Customer
    {
        private DateTime dateOfBirth;
        private string personalIdNumber;

        public DateTime DateOfBirth
        {
            get
            {
                return this.dateOfBirth;
            }
            private set
            {
                if (!this.IsOfAge(value))
                {
                    throw new ArgumentException("Customer must be atleast 18 year old.");
                }
                this.dateOfBirth = value;
            }
        }

        private bool IsOfAge(DateTime dateOfBirth)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - dateOfBirth.Year;
            if (dateOfBirth > today.AddYears(-age)) age--;
            if (age >= 18)
            {
                return true;
            }
            return false;
        }

        public string PersonalIdNumber
        {
            get
            {
                return this.personalIdNumber;
            }
            private set
            {
                if (this.personalIdNumberIsValid(value))
                {
                    throw new ArgumentException("Invalid personal ID number.");
                }
                this.personalIdNumber = value;
            }
        }

        private bool personalIdNumberIsValid(string personalIdNumber)
        {
            if (string.IsNullOrEmpty(personalIdNumber) || personalIdNumber.Length!=10)
            {
                return false;
            }
            foreach (var ch in personalIdNumber)
            {
                if (!char.IsDigit(ch))
	            {
                    return false;
	            }
            }
            return true;
        }

        public Gender Gender
        {
            get;
            private set;
        }

        public Individual(string customerNumber, string name, string persoalIdNumber, DateTime dateOfBirth, Gender gender) :
            base(customerNumber, name)
        {
            this.PersonalIdNumber = persoalIdNumber;
            this.DateOfBirth = dateOfBirth;
            this.Gender = gender;
        }
    }
}
