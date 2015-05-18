//Problem 2. Random numbers

//Write a program that generates and prints to the console 10 random values in the range [100, 200].

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace RandomNumbers
{
    class RandomNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Chose how many random numbers you want: ");
            int amount = int.Parse(Console.ReadLine());
            

            for (int i = 0; i <amount; i++)
            {
                Random number = new Random();
                    Console.Write("{0,3}   ",number.Next(100, 200));
                    Thread.Sleep(100);
            }
            Console.WriteLine();
        }
    }
}
