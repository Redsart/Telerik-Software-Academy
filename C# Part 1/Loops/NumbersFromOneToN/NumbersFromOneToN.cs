//Problem 1. Numbers from 1 to N

//Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space.

using System;

class NumbersFromOneToN
{
    static void Main()
    {
        Console.Write("Please enter a positive integer: ");
        int number = int.Parse(Console.ReadLine());
        int counter = 0;
        while (counter < number)
        {
            counter++;
                Console.Write(counter + " ");
        }
    }
}

