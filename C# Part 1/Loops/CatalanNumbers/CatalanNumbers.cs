//Problem 8. Catalan Numbers

//In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
//Write a program to calculate the n'th Catalan number by given n (0 ≤ n ≤ 100).

using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.Write("Please enter n: ");
        int n = int.Parse(Console.ReadLine());
        BigInteger dividend = 1;
        BigInteger divider = 1;

        if (0<n && n< 100)
        {
            for (int i = 2 * n; i > n + 1; i--)
            {
                dividend *= i;
            }
            for (int i = 1; i <= n; i++)
            {
                divider *= i;
            }
            BigInteger result = dividend / divider;
            Console.WriteLine("The catalan number is: {0}",result);
        }
        else
        {
            Console.WriteLine("Please ener a number diferent by zero!");
        }
    }
}

