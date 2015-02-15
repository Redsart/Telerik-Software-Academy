//Problem 8. Prime Number Check

//Write an expression that checks if given positive integer number n (n <= 100) is prime (i.e. it is divisible without remainder only to itself and 1).
//Note: You should check if the number is positive

using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());
        bool prime = false;
        if (n > 1 && n < 101)
        {
            if (n == 2 || n == 3 || n == 5 || n == 7)
            {
                prime = true;
            }
            else if (n % 2 != 0 && n % 3 != 0 && n % 5 != 0 && n % 7 != 0)
            {
                prime = true;
            }
        }
        Console.WriteLine("The number is prime: " + prime);
    }
}
