//Problem 1. Sum of 3 Numbers

//Write a program that reads 3 real numbers from the console and prints their sum.

using System;

class SumNumbers
{
    static void Main()
    {
        Console.Write("Please enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Please enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Please enter third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());
        int result = firstNumber + secondNumber + thirdNumber;
        Console.WriteLine("The sum of {0}+{1}+{2}={3}",firstNumber, secondNumber, thirdNumber, result);
    }
}

