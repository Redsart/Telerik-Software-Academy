//Problem 5. Formatting Numbers

//Write a program that reads 3 numbers:
//    integer a (0 <= a <= 500)
//    floating-point b
//    floating-point c
//The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
//    The number a should be printed in hexadecimal, left aligned
//    Then the number a should be printed in binary form, padded with zeroes
//    The number b should be printed with 2 digits after the decimal point, right aligned
//    The number c should be printed with 3 digits after the decimal point, left aligned.

using System;

class FormatNumbers
{
    static void Main()
    {
        Console.Write("a=");
        int numberA = int.Parse(Console.ReadLine());
        if (0 <= numberA && numberA <= 500)
        {
            Console.Write("b=");
            double numberB = double.Parse(Console.ReadLine());
            Console.Write("c=");
            double numberC = double.Parse(Console.ReadLine());
            string bitNumberA = Convert.ToString(numberA, 2).PadLeft(10, '0');
            Console.WriteLine("|{0,-10:X}|{1}|{2,10:0.00}|{3,-10:0.000}|", numberA, bitNumberA, numberB, numberC);
        }
        else
            {
                Console.WriteLine("Incorect number!");
            }
    }
}

