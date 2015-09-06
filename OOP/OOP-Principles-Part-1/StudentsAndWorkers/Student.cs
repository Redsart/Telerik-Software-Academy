using System;

namespace StudentsAndWorkers
{
    public class Student : Human
    {
        private double grade;

        public double Grade
        {
            get
            {
                return this.grade;
            }
            private set
            {
                if (value<2 || value>6)
                {
                    throw new ArgumentException("Grade must be 2< >6.");
                }
                this.grade = value;
            }
        }

        public Student(string firstName, string LastName, double grade) : base(firstName,LastName)
        {
            this.Grade = grade;
        }
    }
}
