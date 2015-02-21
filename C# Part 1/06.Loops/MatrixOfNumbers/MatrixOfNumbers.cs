//Problem 9. Matrix of Numbers

//Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. 
//Use two nested loops.

using System;

class MatrixOfNumbers
{
    static void Main()
    {
        Console.Write("Pleaser enter a positive integer form 1 to 20: ");
        int n = int.Parse(Console.ReadLine());

        if (n > 0 && n <= 20)
        {
            for (int row = 1; row <= n; row++)
            {
                for (int coll = 0; coll < n; coll++)
                {
                    Console.Write("{0,2} ", coll + row);
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("The number must be form 1 to 20!");
        }
    }
}

