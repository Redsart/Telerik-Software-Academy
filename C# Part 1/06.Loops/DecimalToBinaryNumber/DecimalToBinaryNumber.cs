//Problem 14. Decimal to Binary Number

//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

using System;
using System.Text;

class DecimalToBinaryNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an integer number :");
        long dec = long.Parse(Console.ReadLine());
        long remainder;
        StringBuilder binary = new StringBuilder();
        while (dec > 0)
        {
            int index = 0;
            remainder = dec % 2;
            binary.Insert(index, remainder);
            dec /= 2;
            index++;
        }
        Console.WriteLine(binary);
    }
}

