using System;

namespace StudentsAndWorkers
{
    public class Worker : Human
    {
        private double weekSalary;
        private double workHoursPerDay;

        public double WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            private set
            {
                if (value<0)
                {
                    throw new ArgumentException("Salary must be more than 0.");
                }
                this.weekSalary = value;
            }
        }

        public double WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            private set
            {
                if (value<0)
                {
                    throw new ArgumentException("Work hours must be > 0.");
                }
                this.workHoursPerDay = value;
            }
        }

        public Worker(string firstName, string lastName, double weekSalary, double workHours) : base(firstName,lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHours;
        }

        public double MoneyPerHour()
        {
            double moneyPerHour=this.WeekSalary/(this.WorkHoursPerDay*5);
            return moneyPerHour;
        }
    }
}
