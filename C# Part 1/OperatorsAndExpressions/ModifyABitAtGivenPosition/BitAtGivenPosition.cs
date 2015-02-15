//Problem 14. Modify a Bit at Given Position

//We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.

using System;

class BitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Enter integer: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter bit value: ");
        int v = int.Parse(Console.ReadLine());
        Console.Write("Enter position: ");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(n,2).PadLeft(32,'0'));
        int newValue;
        int bitAtRight;
        if (v == 1)
        {
        bitAtRight = 1 << p;
        newValue = n | bitAtRight;
        Console.WriteLine(Convert.ToString(newValue, 2).PadLeft(32,'0'));
        Console.WriteLine("Result = " + newValue);
        }
            else if (v == 0)
            {
            bitAtRight = ~(1 << p);
            newValue = n & bitAtRight;
            Console.WriteLine(Convert.ToString(newValue, 2).PadLeft(32,'0'));
            Console.WriteLine("Result = " + newValue);
            }
            else
            {
            Console.WriteLine("Invalid input");
        }
    }

}


