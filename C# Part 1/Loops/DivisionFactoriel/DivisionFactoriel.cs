//Problem 6. Calculate N! / K!

//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//Use only one loop.

using System;
using System.Numerics;

class DivisionFactoriel
{
    static void Main()
    {
        Console.Write("Please enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter k: ");
        int k = int.Parse(Console.ReadLine());
        BigInteger result = 1;

        if (1 < k && k < n && n < 100)    
        {
            for (int i = k+1; i <= n; i++)
            {
                result *= i;
            }
            Console.WriteLine("n!/k!={0}",result);
        }
    }
}

