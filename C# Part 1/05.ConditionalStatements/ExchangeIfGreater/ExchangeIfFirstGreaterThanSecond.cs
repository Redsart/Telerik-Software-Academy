//Problem 1. Exchange If Greater

//Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space.

using System;

class ExchangeIfFirstGreaterThanSecond
{
    static void Main()
    {
        Console.Write("Please enter number a: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Please enter number b: ");
        double secondNumber = double.Parse(Console.ReadLine());

        if (firstNumber > secondNumber)
        {
            firstNumber = firstNumber + secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber = firstNumber - secondNumber;
            Console.WriteLine("{0} {1}", firstNumber, secondNumber);
        }
        Console.WriteLine("{0} {1}",firstNumber,secondNumber);
    }
}

