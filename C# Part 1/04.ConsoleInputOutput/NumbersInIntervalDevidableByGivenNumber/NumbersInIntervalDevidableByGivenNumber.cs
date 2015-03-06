//Problem 11.* Numbers in Interval Dividable by Given Number

//Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder 
//of the division by 5 is 0.

using System;

class NumbersInIntervalDevidableByGivenNumber
{
    static void Main()
    {
        
        Console.Write("Please enter start number: ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("Please enter end number: ");
        int end = int.Parse(Console.ReadLine());
        Console.Write("Please enter divider: ");
        int divider = int.Parse(Console.ReadLine());
        int p = 0;

        //count from start to end
        for (int i = start; i <= end; i++)
        {
            if (i%divider==0)
            {
                p++;
            }
        }
        Console.WriteLine("p={0}",p);
    }
}
