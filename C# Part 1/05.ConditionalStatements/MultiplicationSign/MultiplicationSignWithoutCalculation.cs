//Problem 4. Multiplication Sign

//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//    Use a sequence of if operators.

using System;

class MultiplicationSignWithoutCalculation
{
    static void Main()
    {
        Console.Write("Please enter number a: ");
        double numberA = double.Parse(Console.ReadLine());
        Console.Write("Please enter number b: ");
        double numberB = double.Parse(Console.ReadLine());
        Console.Write("Please enter number c: ");
        double numberC = double.Parse(Console.ReadLine());

         if (numberA == 0 || numberB == 0 || numberC == 0)
        {
            Console.WriteLine("0");
        }
         else if (numberA > 0 || numberB > 0 || numberC > 0)
        {
            Console.WriteLine("+");
        }
        else
        {
            Console.WriteLine("-");
        }
    }
}

