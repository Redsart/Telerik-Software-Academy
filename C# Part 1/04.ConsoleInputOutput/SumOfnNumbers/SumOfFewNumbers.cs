using System;

class SumOfFewNumbers
{
    static void Main()
    {
    Console.Write("Please enter the count of numbers: ");
    double number = double.Parse(Console.ReadLine());
    double sum = 0;
    for (double i = 1; i <= number; i++)
        {
            Console.WriteLine("Enter the {0} number", i);
            double numberI = double.Parse(Console.ReadLine());
            sum += numberI;
            Console.WriteLine("Sum is {0}", sum);
        }
    }
}

