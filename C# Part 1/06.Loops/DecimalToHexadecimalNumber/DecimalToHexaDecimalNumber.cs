//Problem 16. Decimal to Hexadecimal Number

//Using loops write a program that converts an integer number to its hexadecimal representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

using System;
using System.Text;

class DecimalToHexaDecimalNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an integer number :");
        long number = long.Parse(Console.ReadLine());
        StringBuilder binary = new StringBuilder();
        while (number > 0)
        {
            int index = 0;
            char hexValue = '0';
            long remainder = number % 16;
            if (remainder > 9)
            {
                switch (remainder)
                {
                    case 10: hexValue = 'A';
                        break;
                    case 11: hexValue = 'B';
                        break;
                    case 12: hexValue = 'C';
                        break;
                    case 13: hexValue = 'D';
                        break;
                    case 14: hexValue = 'E';
                        break;
                    case 15: hexValue = 'F';
                        break;
                    default: Console.WriteLine("Fail");
                        break;
                }
                binary.Insert(index, hexValue);
            }
            else
            {
                binary.Insert(index, remainder);
            }
            number /= 16;
            index++;
        }
        Console.WriteLine(binary);
    }
}

