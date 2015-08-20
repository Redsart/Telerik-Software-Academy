using System;

namespace Students
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private int age;

        public Student(string fName, string lName, int age)
        {
            this.firstName = fName;
            this.lastName = lName;
            this.age = age;
        }

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
                else
                {
                    this.firstName = value;
                }
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
                    throw new ArgumentNullException("Last name cant be null or empty");
                }
                else
                {
                    this.lastName = value;
                }
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if (0 > value || value < 150)
                {
                    throw new ArgumentOutOfRangeException("Ages of the student must be in range 0-150");
                }
                else
                {
                    this.age = value;
                }
            }
        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2} years old."
                ,this.firstName,this.lastName,this.age);
        }
    }
}
