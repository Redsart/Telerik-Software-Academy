//Problem 7. Reverse number

//Write a method that reverses the digits of given decimal number.
//  Example:
//  input 	 |   output
//  256 	 |   652
//  123.45 	 |   54.321

using System;
using System.Linq;

class ReverseNumber
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        decimal number = int.Parse(Console.ReadLine());
        decimal reversed = ReverseDecimal(number);
        Console.WriteLine("Reversed: {0}",reversed);
    }

    static decimal ReverseDecimal(decimal number)
    {
        return decimal.Parse(new string(number.ToString().ToCharArray().Reverse().ToArray()));
    }
}

