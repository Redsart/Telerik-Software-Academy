//Problem 17. Date in Bulgarian

//Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints the date and time after 
//6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DateInBulgarian
{
    class DateInBulgarian
    {
        static void Main(string[] args)
        {
            string[] firstDateAndHour = Console.ReadLine().Split('.', ' ', ':');
            int day = int.Parse(firstDateAndHour[0]);
            int month = int.Parse(firstDateAndHour[1]);
            int year = int.Parse(firstDateAndHour[2]);
            int hour = int.Parse(firstDateAndHour[3]);
            int minute = int.Parse(firstDateAndHour[4]);
            int second = int.Parse(firstDateAndHour[5]);
            DateTime dateAndTime = new DateTime(year, month, day, hour, minute, second);

            var culture = new System.Globalization.CultureInfo("bg-BG");
            var dayOfWeek = culture.DateTimeFormat.GetDayName(dateAndTime.DayOfWeek);

            Console.WriteLine("The time now is: {0}",dateAndTime);
            Console.WriteLine("The day of week is: {0}",dayOfWeek);

            dateAndTime = dateAndTime.AddHours(6).AddMinutes(30);
            dayOfWeek = culture.DateTimeFormat.GetDayName(dateAndTime.DayOfWeek);

            Console.WriteLine("The time after 6 hours and 30 minutes: {0}",dateAndTime);
            Console.WriteLine("Day of week is: {0}",dayOfWeek);
        }
    }
}
