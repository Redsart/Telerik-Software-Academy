//Problem 3. Circle Perimeter and Area

//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.

using System;

class PerimeterAndAreaOfCircle
{
    static void Main()
    {
        Console.Write("Please enter circle radius: ");
        double radius = double.Parse(Console.ReadLine());
        double circlePerimeter = (2 * Math.PI * radius);
        double circleArea = Math.PI * (radius*radius);
        Console.WriteLine("Perimeter of circle is: {0:0.00}",circlePerimeter);
        Console.WriteLine("Area of circle is: {0:0.00}",circleArea);
    }
}

