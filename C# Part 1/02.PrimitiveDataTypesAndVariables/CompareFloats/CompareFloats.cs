//Problem 13.* Comparing Floats

//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.

//Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic. 
//Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.

using System;

class CompareFloats
{
    static void Main()
    {
        Console.WriteLine("This program compare two numbers with precision eps=0.000001.");
        Console.Write("Please enter number a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please enter number b: ");
        double b = double.Parse(Console.ReadLine());

        if (a-b>=0.000001 || b-a>=0.000001)
        {
            
            Console.WriteLine("False! The difference is >= eps. We consider the numbers are different.");
        }
        
        else
        {
            
            Console.WriteLine("True! The difference of numbers is < eps. We consider the numbers are equal.");
        }
    }
}

