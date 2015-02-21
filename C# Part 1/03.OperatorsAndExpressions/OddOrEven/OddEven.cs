//Problem 1. Odd or Even Integers

//Write an expression that checks if given integer is odd or even.

using System;

class OddEven
{
    static void Main()
    {
        Console.WriteLine("Chose one of the numbers: 3, 2, -2, -1, 0 and see, is odd or even:");
        int evenNumber=Convert.ToInt32(Console.ReadLine());
        if (evenNumber%2==0)
        {
    Console.WriteLine(evenNumber + ":is even");
}
else
{
    Console.WriteLine(evenNumber + ":is odd");
}
    }
}
