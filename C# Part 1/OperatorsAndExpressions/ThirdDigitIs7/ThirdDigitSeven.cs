//Problem 5. Third Digit is 7?

//Write an expression that checks for given integer if its third digit from right-to-left is 7.

using System;

class ThirdDigitSeven
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        bool check=(number / 100) % 10==7 ;
        Console.WriteLine("The third digit (right-to-left) of: " + number + " is 7 : " + check);
    }
}

