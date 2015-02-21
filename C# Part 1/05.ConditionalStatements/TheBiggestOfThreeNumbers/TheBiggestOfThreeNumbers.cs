//Problem 5. The Biggest of 3 Numbers

//Write a program that finds the biggest of three numbers.

using System;

class TheBiggestOfThreeNumbers
{
    static void Main()
    {
        Console.Write("Please enter number a: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Please enter number b: ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("Please enter number c: ");
        double thirdNumber = double.Parse(Console.ReadLine());
        if (firstNumber > secondNumber && firstNumber > thirdNumber)
        {
            Console.WriteLine("The biggest number is: {0}",firstNumber);
        }
        else if (secondNumber > firstNumber && secondNumber > thirdNumber)
        {
            Console.WriteLine("The biggest number is: {0}",secondNumber);
        }
        else if (thirdNumber > firstNumber && thirdNumber > secondNumber)
        {
            Console.WriteLine("The biggest number is: {0}",thirdNumber);
        }
    }
}

