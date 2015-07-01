//Problem 2. Reverse string

//Write a program that reads a string, reverses it and prints the result at the console.

using System;

namespace ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text: ");
            string s=Console.ReadLine();
            char[] cArray = s.ToCharArray();
            Array.Reverse(cArray);
            Console.Write("Reversed text is:",cArray);
        }
    }
}
