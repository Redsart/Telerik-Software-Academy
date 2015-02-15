//Problem 10. Fibonacci Numbers

//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number n=");
        long number = long.Parse(Console.ReadLine());
        long firstNumber = 0;
        long secondNumber = 1;
        long sum;
        for (int i = 0; i < number; i++)
        {
            Console.WriteLine(firstNumber);
            sum = firstNumber + secondNumber;
            firstNumber = secondNumber;
            secondNumber = sum;
        }
    }
}


