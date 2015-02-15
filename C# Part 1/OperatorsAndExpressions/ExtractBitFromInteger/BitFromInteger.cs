//Problem 12. Extract Bit from Integer

//Write an expression that extracts from given integer n the value of given bit at index p.

using System;

class BitFromInteger
{
    static void Main()
    {
        Console.Write("Enter an integer n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter an integer for position p: ");
        int p = Convert.ToInt32(Console.ReadLine());
        byte bitPosition = (byte)((n >> p) & 1);
        Console.WriteLine("byte at positon " + p + "is:" + bitPosition);
    }
}

