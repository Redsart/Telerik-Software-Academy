//Problem 17. Longest string

//Write a program to return the string with maximum length from an array of strings.
//Use LINQ.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LongestString
{
    class LongestString
    {
        static void Main(string[] args)
        {
            string[] someString =
            {
                "do",
                "something",
                "short",
                "long",
                "longestString"
            };

            var sort =
                from strings in someString
                orderby strings.Length descending
                select strings;

            string longest = sort.FirstOrDefault();
            Console.WriteLine(longest);
        }
    }
}
