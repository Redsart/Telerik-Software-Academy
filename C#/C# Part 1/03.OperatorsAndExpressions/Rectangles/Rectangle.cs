//Problem 4. Rectangles

//Write an expression that calculates rectangle’s perimeter and area by given width and height.

using System;

class Rectangle
{
    static void Main()
    {
        Console.Write("Enter width: ");
        double width = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter height: ");
        double height = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Perimeter of rectangle: " + (2*(width + height)));
        Console.WriteLine("Area of rectangle: "+(width * height));
    }
}

