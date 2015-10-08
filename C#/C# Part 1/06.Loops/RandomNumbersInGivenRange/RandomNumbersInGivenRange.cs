//Problem 11. Random Numbers in Given Range

//Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].

using System;

class RandomNumbersInGivenRange
{
    static void Main()
    {
        Console.Write("Please enter min: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Please enter max: ");
        int max = int.Parse(Console.ReadLine());
        Console.Write("Please enter n: ");
        int n = int.Parse(Console.ReadLine());
        Random number = new Random();

        for (int i =0 ; i < n; i++)
        {
            Console.Write("{0,5}",number.Next(min, max));
        }
        Console.WriteLine();
    }
}

