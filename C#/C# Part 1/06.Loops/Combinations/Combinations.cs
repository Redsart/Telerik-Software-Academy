//Problem 7. Calculate N! / (K! * (N-K)!)

//In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.

using System;
using System.Numerics;

class Combinations
{
    static void Main()
    {
        Console.Write("Please enter n: ");
        int elements = int.Parse(Console.ReadLine());
        Console.Write("Please enter k: ");
        int members = int.Parse(Console.ReadLine());
        BigInteger fact1 = 1;
        BigInteger fact2 = 1;
        if (1 < members && members < elements && elements < 100)
        {
            for (int i = members+1; i <= elements; i++)
            {
                fact1 *= i;
            }
            for (int j = 1; j <= (elements-members); j++)
            {
                fact2 *= j;
            }
        }
        else;
	    {
            Console.WriteLine("Invalid Input!");
	    }
        BigInteger result=fact1 / fact2 ;
        Console.WriteLine("n!/k! * (n-k)!={0}",result);
    }
}

