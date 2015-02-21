//Problem 7. Sort 3 Numbers with Nested Ifs

//Write a program that enters 3 real numbers and prints them sorted in descending order.
//    Use nested if statements.

using System;

class SortThreeNumbersWithNestedIfs
{
    static void Main()
    {
        Console.Write("Please enter number a: ");
        double numberA = double.Parse(Console.ReadLine());
        Console.Write("Please enter number b: ");
        double numberB = double.Parse(Console.ReadLine());
        Console.Write("Please enter number c: ");
        double numberC = double.Parse(Console.ReadLine());
        double first = 0;
        double second = 0;
        double third = 0;
        if (numberA >= numberB)
        {
        if (numberA >= numberC)
        {
        first = numberA;
            if (numberB >= numberC)
            {
            second = numberB;
            third = numberC;
            }
            else
            {
            second = numberC;
            third = numberB;
            }
                }
                else
                {
                first = numberC;
                second = numberA;
                third = numberB;
                }
            }
        else
        {
        if (numberB >= numberC)
        {
        first = numberB;
            if (numberA >= numberC)
            {
            second = numberA;
            third = numberC;
            }
            else
            {
            second = numberC;
            third = numberA;
            }
        }
        else
        {
        first = numberC;
        second = numberB;
        third = numberC;
        }
        }
        Console.WriteLine(first + " " + second + " " + third);
    }
}

