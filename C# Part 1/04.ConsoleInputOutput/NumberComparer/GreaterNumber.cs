//Problem 4. Number Comparer

//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.

using System;

class GreaterNumber
{
    static void Main()
    {
        Console.Write("Please enter number a: ");
        int numberA = int.Parse(Console.ReadLine());
        Console.Write("Please enter number b: ");
        int numberB = int.Parse(Console.ReadLine());
        Console.WriteLine("The greater number is: " + Math.Max(numberA, numberB));
    }
}

