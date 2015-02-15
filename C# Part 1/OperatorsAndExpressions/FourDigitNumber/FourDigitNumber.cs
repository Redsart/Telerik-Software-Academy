//Problem 6. Four-Digit Number

//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//    Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//    Prints on the console the number in reversed order: dcba (in our example 1102).
//    Puts the last digit in the first position: dabc (in our example 1201).
//    Exchanges the second and the third digits: acbd (in our example 2101).

//The number has always exactly 4 digits and cannot start with 0.
using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.Write("Enter four digit number: ");
        int number = int.Parse(Console.ReadLine());
        int d = number % 10;
        number /= 10;
        int c = number % 10;
        number /= 10;
        int b = number % 10;
        number /= 10;
        int a = number % 10;
        Console.WriteLine("Sum of the digits is: " + (a + b + c + d));
        int reversedNumber = d * 1000 + c * 100 + b * 10 + a;
        Console.WriteLine("Reversed number: " + reversedNumber);
        int lastDigitFirst = d * 1000 + a * 100 + b * 10 + c;
        Console.WriteLine("Last digit first: " + lastDigitFirst);
        int exchangeSecondAndThird = a * 1000 + c * 100 + b * 10 + d;
        Console.WriteLine("Exchange second and third: " + exchangeSecondAndThird);
    }
}

