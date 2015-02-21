//Problem 6. The Biggest of Five Numbers

//Write a program that finds the biggest of five numbers by using only five if statements.

using System;

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        Console.Write("Please enter number a: ");
        double numberA = double.Parse(Console.ReadLine());
        Console.Write("Please enter number b: ");
        double numberB = double.Parse(Console.ReadLine());
        Console.Write("Please enter number c: ");
        double numberC = double.Parse(Console.ReadLine());
        Console.Write("Please enter number d: ");
        double numberD = double.Parse(Console.ReadLine());
        Console.Write("Please enter number e: ");
        double numberE = double.Parse(Console.ReadLine());
        if (numberA > numberB && numberA > numberC && numberA > numberD && numberA > numberE)
        {
            Console.WriteLine("The biggest number is a={0}",numberA);
        }
        else if (numberB > numberA && numberB > numberC && numberB > numberD && numberB > numberE)
        {
            Console.WriteLine("The biggest number is b={0}",numberB);
        }
        else if (numberC > numberA && numberC > numberB && numberC > numberD && numberC > numberE)
        {
            Console.WriteLine("The biggest number is c={0}",numberC);
        }
        else if (numberD > numberA && numberD > numberB && numberD > numberC && numberD > numberE)
        {
            Console.WriteLine("The biggest number is d={0}",numberD);
        }
        else if (numberE > numberA && numberE > numberB && numberE > numberC && numberE > numberD)
        {
            Console.WriteLine("The biggest number is e={0}", numberE);
        }
    }
}

