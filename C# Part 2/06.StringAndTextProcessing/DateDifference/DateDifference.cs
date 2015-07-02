//Problem 16. Date difference

//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.

//Example:

//Enter the first date: 27.02.2006
//Enter the second date: 3.03.2006
//Distance: 4 days

using System;

namespace DateDifference
{
    class DateDifference
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first date in format day.month.year: ");
            string[] firstDate = Console.ReadLine().Split('.');
            int firstDay = int.Parse(firstDate[0]);
            int firstMonth = int.Parse(firstDate[1]);
            int firstYear = int.Parse(firstDate[2]);
            DateTime dateOne = new DateTime(firstYear,firstMonth,firstDay);

            Console.Write("Enter second date in format day.month.year: ");
            string[] secondDate = Console.ReadLine().Split('.');
            int secondDay = int.Parse(secondDate[0]);
            int secondMonth = int.Parse(secondDate[1]);
            int secondYear = int.Parse(secondDate[2]);
            DateTime dateTwo = new DateTime(secondYear,secondMonth,secondDay);

            int daysBetween = Math.Abs((dateOne - dateTwo).Days);
            Console.WriteLine("{0} days.",daysBetween);
        }
    }
}
