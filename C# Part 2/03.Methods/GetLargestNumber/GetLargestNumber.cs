//Problem 2. Get largest number

//Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

using System;

class GetLargestNumber
{
    static int GetMax(int firstNumber, int secondNumber)
    {
        int greaterNumber = firstNumber;
        if (firstNumber<secondNumber)
        {
            greaterNumber = secondNumber;
        }
        return greaterNumber;
    }
    static void Main()
    {
        Console.Write("Please enter first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Please enter second number: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Please enter third number: ");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine(GetMax(GetMax(a, b),c));
    }
}

