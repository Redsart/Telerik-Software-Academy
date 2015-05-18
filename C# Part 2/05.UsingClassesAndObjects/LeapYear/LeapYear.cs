//Problem 1. Leap year

//Write a program that reads a year from the console and checks whether it is a leap one.

using System;

class LeapYEar
{
    static void Main(string[] args)
    {
        int year = int.Parse(Console.ReadLine());
        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine("{0} is a leap year.", year);
            DateTime leapDay = new DateTime(year, 2, 29);
        }
        else
        {
            Console.WriteLine("{0} Is not a leap year.", year);
        }
    }
}

