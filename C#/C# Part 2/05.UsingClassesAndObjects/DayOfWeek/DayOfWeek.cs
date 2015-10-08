//Problem 3. Day of week

//Write a program that prints to the console which day of the week is today.
using System;

class DayOfWeek
{
    static void Main(string[] args)
    {
        DateTime datetime = DateTime.Now;
        string day = datetime.DayOfWeek.ToString("");
        switch (day)
        {
            case "1":
                day = "Monday";
                break;
            case"2":
                day = "Thuesday";
                break;
            case "3":
                day = "Wednesday";
                break;
            case "4":
                day = "Thursday";
                break;
            case "5":
                day = "Friday";
                break;
            case "6":
                day = "Saturday";
                break;
            case "7":
                day = "Sunday";
                break;
        }
        Console.WriteLine("Today is {0}, and it's {1}",DateTime.Now,day); 
    }
}

