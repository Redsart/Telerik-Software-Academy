//Problem 6. Quadratic Equation

//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).

using System;

class SolveQuadraticEquations
{
    static void Main()
    {
        Console.Write("a=");
        double coefficientA = double.Parse(Console.ReadLine());
        Console.Write("b=");
        int coefficientB = int.Parse(Console.ReadLine());
        Console.Write("c=");
        int coefficientC = int.Parse(Console.ReadLine());
        double discriminant = (coefficientB * coefficientB) - (4 * coefficientA * coefficientC);
        double firstRoot = (-coefficientB - Math.Sqrt(discriminant)) / (2 * coefficientA);
        double secondRoot = (-coefficientB + Math.Sqrt(discriminant)) / (2 * coefficientA);
        if (discriminant>0)
        { 
        Console.WriteLine("x1=" + firstRoot);
        Console.WriteLine("x2=" + secondRoot);
        }
        else
        {
            Console.WriteLine("No real roots!");
        }
    }
}

