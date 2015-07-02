//Problem 24. Order words

//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

using System;

namespace OrderWords
{
    class OrderWords
    {
        static void Main(string[] args)
        {
            Console.Write("Enter words separated by spaces: ");
            string[] words = (Console.ReadLine()).Split(' ');

            Array.Sort(words);
            Console.WriteLine("Youre words in alphanetical orders is: ");
            Console.WriteLine(string.Join(" ",words));
        }
    }
}
