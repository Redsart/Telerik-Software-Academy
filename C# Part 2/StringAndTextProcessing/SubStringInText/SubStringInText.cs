//Problem 4. Sub-string in text

//Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).

using System;

namespace SubStringInText
{
    class SubStringInText
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter text: ");
            string someString = Console.ReadLine();
            Console.Write("Enter target sub-string: ");
            string subString = Console.ReadLine();
            int counter = 0;

            for (int i = 0; i < someString.Length; i++)
            {
                int index = someString.IndexOf(subString,i);
                if (index==i)
                {
                    counter++;
                }
            }

            Console.WriteLine("The result is: {0}",counter);
        }
    }
}
