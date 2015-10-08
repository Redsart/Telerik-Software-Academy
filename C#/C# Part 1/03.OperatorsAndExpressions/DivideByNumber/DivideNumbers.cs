//Problem 3. Divide by 7 and 5

//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

using System;

class DivideNumbers
{
    static void Main()
    {
        Console.Write("Is this number can divide by 7 and 5 at the same time.Please write a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        bool check=(number%7==0)&&(number%5==0);
        Console.WriteLine(number+" Yes can be divided by 7 and 5 at the same time: "+check);
    }
}

