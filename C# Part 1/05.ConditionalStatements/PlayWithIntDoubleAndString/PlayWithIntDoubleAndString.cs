﻿//Problem 9. Play with Int, Double and String

//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//    If the variable is int or double, the program increases it by one.
//    If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.

using System;

class PlayWithIntDoubleAndString
{
    static void Main()
    {

        Console.Write("Please chose a type: ");
        int number = int.Parse(Console.ReadLine());
        switch (number)
        {
            case 1: Console.Write("Please enter integer: ");
                int integerNum = Int32.Parse(Console.ReadLine());
                Console.WriteLine(++integerNum);
                break;
            case 2: Console.Write("Please enter double: ");
                double doubleNum = Double.Parse(Console.ReadLine());
                Console.WriteLine(++doubleNum);
                break;
            case 3: Console.Write("Please enter string: ");
                string stringInput = Console.ReadLine();
                Console.WriteLine(stringInput + "*");
                break;
            default: Console.WriteLine("Invalid option");
                break;
        }
    }
}

