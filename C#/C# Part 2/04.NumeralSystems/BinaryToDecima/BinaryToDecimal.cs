//Problem 2. Binary to decimal

//Write a program to convert binary numbers to their decimal representation.

using System;

class BinaaryToDecimal
{
    static void Main()
    {
        Console.Write("Please enter binary: "); 
        int binary = int.Parse(Console.ReadLine());
        string strBinary = binary.ToString();
        char[] array = strBinary.ToCharArray();
        int dec = 0;
        int digit;

        for (int i = 0; i < array.Length; i++)
        {
            digit = (int)Char.GetNumericValue(array[array.Length - 1 - i]);
            dec += digit * (int)Math.Pow(2, i);
        }
        Console.Write("In decimal: {0}", dec); 
    }
}

