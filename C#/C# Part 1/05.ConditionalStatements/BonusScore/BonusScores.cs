//Problem 2. Bonus Score

//Write a program that applies bonus score to given score in the range [1…9] by the following rules:
//    If the score is between 1 and 3, the program multiplies it by 10.
//    If the score is between 4 and 6, the program multiplies it by 100.
//    If the score is between 7 and 9, the program multiplies it by 1000.
//    If the score is 0 or more than 9, the program prints “invalid score”.

using System;

class BonusScores
{
    static void Main()
    {
        Console.Write("Please enter number in the range [1...9] : ");
        int numberInRange = int.Parse(Console.ReadLine());
        if (numberInRange >= 1 && numberInRange <= 3)
        {
            Console.WriteLine("score: {0} - result: {1}", numberInRange, (numberInRange * 10));
        }
        else if (numberInRange>=4 && numberInRange<=6)
        {
            Console.WriteLine("score: {0} - result: {1}",numberInRange,(numberInRange * 100));
        }
        else if (numberInRange >= 7 && numberInRange <= 9)
        {
            Console.WriteLine("score: {0} - result: {1}", numberInRange, (numberInRange * 1000));
        }
        else
        {
            Console.WriteLine("Invalid score! Please enter a number in range [1...9]");
        }
    }
}

