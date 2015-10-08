//Problem 9. Trapezoids

//Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;

class Trapezoid
{
    static void Main()
    {
        Console.Write("Side a: ");
        double sideA = Convert.ToDouble(Console.ReadLine());
        Console.Write("Side b: ");
        double sideB = Convert.ToDouble(Console.ReadLine());
        Console.Write("Height: ");
        double height = Convert.ToDouble(Console.ReadLine());
        double result=(0.5 * height * (sideA + sideB));
        Console.WriteLine("Trapezoid area is: " + result);
    }
}

