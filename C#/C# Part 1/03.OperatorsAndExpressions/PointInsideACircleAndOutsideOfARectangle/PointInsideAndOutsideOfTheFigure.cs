//Problem 10. Point Inside a Circle & Outside of a Rectangle

//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;

class PointInsideAndOutsideOfTheFigure
{
    static void Main()
    {
        Console.Write("Enter x position: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter y position: ");
        double y = Convert.ToDouble(Console.ReadLine());
        double radius = 1.5;
        bool insideCircle = ((x - 1) * (x - 1) + (y - 1) * (y)) <=(radius * radius);
        bool outsideRectangle = ((x < -1) || (x > 5) || (y > 1) || (y < -1));
        bool checkCond = insideCircle && outsideRectangle;
        Console.WriteLine("Point (x,y) with coordinates (" + x + "," + y + ") is within circle K and outside the rectangle R: " + checkCond);
    }
}

