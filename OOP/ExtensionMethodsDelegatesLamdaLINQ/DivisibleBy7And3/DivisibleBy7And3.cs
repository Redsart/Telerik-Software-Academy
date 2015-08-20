﻿//Problem 6. Divisible by 7 and 3

//Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. Use the built-in extension methods and 
//lambda expressions. Rewrite the same with LINQ.

using System;
using System.Linq;

namespace DivisibleBy7And3
{
    class DivisibleBy7And3
    {
        static void Main(string[] args)
        {
            var testArray = Enumerable.Range(1, 50).ToArray();
            Console.WriteLine("Numbers in the array: \n{0}",string.Join(", ",testArray));

            var divisible = testArray.Where(x=> x%3==0 && x%7==0);
            Console.WriteLine("Numbers divisible by 3 and 7(using Lambda): \n{0}",string.Join(", ",divisible));

            var divisible2 =
                from number in testArray
                where number % 3 == 0 && number % 7 == 0
                select number;
            Console.WriteLine("Numbers divisible by 3 and 7 (using LINQ): \n{0}, ",string.Join(", ",divisible2));
        }
    }
}
