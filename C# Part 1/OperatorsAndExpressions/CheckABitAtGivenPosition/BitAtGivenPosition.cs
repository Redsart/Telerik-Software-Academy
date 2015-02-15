//Problem 13. Check a Bit at Given Position

//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.

using System;

class BitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Integer n=");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Positon p=");
        int p = int.Parse(Console.ReadLine());
        bool bit = ((n >> p) & 1) == 1;
        Console.WriteLine("Is bit at position " + p +" is 1? :"+ bit);
    }
}

