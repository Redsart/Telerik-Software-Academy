//Problem 3. Range Exceptions

//Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range. It should hold 
//error message and a range definition [start … end].
//Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime> by entering numbers 
//in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].

using System;

namespace RangeExceptions
{
    class RangeExceptionsMain
    {
        static void Main(string[] args)
        {
            int[] sampleNumbers = { 50, 250 };

            foreach (var number in sampleNumbers)
            {
                try
                {
                    if (number<0 || number>100)
                    {
                        throw new InvalidRangeException<int>(0, 100);
                    }
                    Console.WriteLine("{0} is in the range.",number);
                }
                catch (InvalidRangeException<int> ex)
                {
                    Console.WriteLine("{0} - {1}",number, ex);
                }
            }

            Console.WriteLine();

            DateTime[] sampleDates = { (new DateTime(1991, 5, 18)), DateTime.Now };
            DateTime startDate = new DateTime(1980, 1, 1);
            DateTime endDate = new DateTime(2013, 12, 31);

            foreach (var date in sampleDates)
            {
                try
                {
                    if (date<startDate || date>endDate)
                    {
                        throw new InvalidRangeException<DateTime>(startDate, endDate);
                    }
                    Console.WriteLine("{0:D} is in range.",date);
                }
                catch (InvalidRangeException<DateTime> ex)
                {
                    Console.WriteLine("{0:D} - {1}",date, ex.Message);
                }
            }
        }
    }
}
