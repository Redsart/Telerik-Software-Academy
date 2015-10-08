//Problem 13. Binary to Decimal Number

//Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

using System;

class BinaryToDecimalNumber
{
    static void Main()
    {
        Console.WriteLine("Enter a binary integer number :");
        string binary = Console.ReadLine();
        long number = 0;
        int power = 1;
        for (int i = binary.Length - 1; i >= 0; i--)
        {
            int sign = binary[i] - 48;
            if (sign == 1)
            {
                number += sign * power;
            }
            power *= 2;
        }
        Console.WriteLine(number);
    }
}

