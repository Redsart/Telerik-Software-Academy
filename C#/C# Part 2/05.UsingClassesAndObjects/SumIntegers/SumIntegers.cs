//Problem 6. Sum integers

//You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum.

using System;

namespace SumIntegers
{
    class SumIntegers
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter numbers given in a single line, separated by a space: ");
            string[] numbers = Console.ReadLine().Split(' ');
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += Convert.ToDouble(numbers[i]);
            }
            Console.WriteLine("Sum is = {0}", sum);
        }
    }
}
