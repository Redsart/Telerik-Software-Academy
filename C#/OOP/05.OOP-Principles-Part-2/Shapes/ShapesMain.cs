//Problem 1. Shapes

//Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
//Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure (height * width 
//for rectangle and height * width/2 for triangle).
//Define class Square and suitable constructor so that at initialization height must be kept equal to width and implement the 
//CalculateSurface() method.
//Write a program that tests the behaviour of the CalculateSurface() method for different shapes (Square, Rectangle, Triangle) stored 
//in an array.

using System;

namespace Shapes
{
    class ShapesMain
    {
        static void Main()
        {
            Shape[] shapes =
            {
                new Rectangle(3.5, 4),
                new Triangle(1.75, 1.5),
                new Square(4),
                new Triangle(2.35, 1.90),
                new Rectangle(2, 3)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine("{0} are: {1}",shape.GetType().Name, shape.CalculateSurface());
            }
        }
    }
}
