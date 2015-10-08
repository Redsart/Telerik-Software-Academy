//Write methods that calculate the surface of a triangle by given:

//Side and an altitude to it;
//Three sides;
//Two sides and an angle between them;

using System;


class TriangleSurface
{
    static void Main(string[] args)
    {
        Console.WriteLine("This program can calculate the surface of triangle.");
        Console.Write("Chose 1 for given side and altitude, 2 for given three sides a,b,c, or 3 for given two sides and angle between them:");
        int choice = int.Parse(Console.ReadLine());

        if (choice==1)
        {
            Console.Write("Enter side a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter altitude: ");
            double h = double.Parse(Console.ReadLine());
            SurfaceBySideAndHeight(a, h);
        }

        else if (choice==2)
        {
            Console.Write("Enter side a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter side b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter side c: ");
            double c = double.Parse(Console.ReadLine());
            SurfaceByThreeSides(a, b, c);
        }

        else if (choice==3)
        {
            Console.Write("Enter side a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter side b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter angle: ");
            double angle = double.Parse(Console.ReadLine());
            SurfaceByTwoSidesAndAngleBetweenThem(a, b, angle);
        } 
    }

    static void SurfaceBySideAndHeight(double side, double height)
    {
        double surface = side * height/2;
        Console.WriteLine("Surface of the triangle by given side and altitude is {0}",surface);
    }

    static void SurfaceByThreeSides(double side1, double side2, double side3)
    {
        double s = (side1 + side2 + side3) / 2;
        double surface = Math.Sqrt(s * (s - side1)*(s-side2)*(s-side3));
        Console.WriteLine("Surface of the triangle by given three sides is {0}",surface);
    }

    static void SurfaceByTwoSidesAndAngleBetweenThem(double side1, double side2, double degrees)
    {
        double angle = Math.PI * degrees / 180.0;
        double surface = ((side1 * side2) / 2) * Math.Sin(angle);
        Console.WriteLine("Surface of the triangle by given two sides and angle is {0}",surface);
    }
}

