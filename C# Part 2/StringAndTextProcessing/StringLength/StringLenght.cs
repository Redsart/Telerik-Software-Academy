//Problem 6. String length

//Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *.
//Print the result string into the console.

using System;
using System.Linq;

namespace StringLength
{
    class StringLenght
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int chCounter = 0;

            foreach (var ch in text)
            {
                chCounter++;
            }

            if (chCounter==20)
            {
                Console.WriteLine(text);
            }

            else if (chCounter>20)
            {
                Console.WriteLine("The text is more than 20 characters.");
            }

            else if (chCounter<20)
            {
                int diference = 20 - chCounter;
                string fill = string.Concat(Enumerable.Repeat("*", diference));
                Console.WriteLine(string.Concat(text,fill));
            }
        }
    }
}
