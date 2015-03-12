using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class RandomizeNumbers
{
    static void Main()
    {
        Console.Write("Please enter n: ");
        int n = int.Parse(Console.ReadLine());
        Random number = new Random();
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0,5}",number.Next(n));
            
        }
        Console.WriteLine();
    }
}

