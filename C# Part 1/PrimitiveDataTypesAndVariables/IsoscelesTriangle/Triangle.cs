//Problem 8. Isosceles Triangle

//Write a program that prints an isosceles triangle of 9 copyright symbols ©.

using System;

class Triangle
{
    static void Main(string[] args)
    {
        char copyrightSymbol = '\u00A9';
        Console.WriteLine(@"
    ©

   © ©

  ©   ©

 © © © ©
");
    }
}

