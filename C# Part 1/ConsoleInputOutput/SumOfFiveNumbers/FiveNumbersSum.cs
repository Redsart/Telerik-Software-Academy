//Problem 7. Sum of 5 Numbers

//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

using System;

class FiveNumbersSum
{
    static void Main()
    {
        Console.Write("Please enter five numbers given in a single line, separated by a space: ");
        string[] numbers = Console.ReadLine().Split(' ');
        double sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += Convert.ToDouble(numbers[i]);
        }
        Console.WriteLine("Sum is = {0}", sum);
    }
}

