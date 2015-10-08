//Problem 1. Decimal to binary

//Write a program to convert decimal numbers to their binary representation.

using System;

class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Please enter number: ");
        int number = int.Parse(Console.ReadLine());
        int binary;
        string str = "";

        while (number != 0)
        {
            binary = number & 1;
            str = binary.ToString() + str;
            number = number >> 1;
        }
        Console.WriteLine("In binary: " + str); 
    }
}

