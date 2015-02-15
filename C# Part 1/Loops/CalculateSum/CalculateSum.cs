//Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N

//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
//Use only one loop. Print the result with 5 digits after the decimal point.

using System;

class CalculateSum
{
    static void Main()
    {
        Console.Write("Please enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter x: ");
        int x = int.Parse(Console.ReadLine());
        double factorial = 1;
        double sum = 1;
        double powerN = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            powerN *= x;
            sum += (factorial / powerN);
        }
        Console.WriteLine("Sum: {0:F5}", sum);
    }
}

