//Problem 1. Square root

//Write a program that reads an integer number and calculates and prints its square root.
//    If the number is invalid or negative, print Invalid number.
//    In all cases finally print Good bye.
//Use try-catch-finally block.

using System;

namespace SquareRoot
{
    class SquareRoot
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter integer number: ");
                int number = int.Parse(Console.ReadLine());
                double result = Math.Sqrt(number);
                Console.WriteLine(result);
            }

            catch (Exception)
            {
                Console.WriteLine("Invalid number!");
            }

            finally
            {
                Console.WriteLine("Good bye");
            }
  
        }
    }
}
