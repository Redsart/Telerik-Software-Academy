//Problem 1. Say Hello

//Write a method that asks the user for his name and prints “Hello, <name>”
//Write a program to test this method.

using System;
using System.Linq;

class SayHelloMethod
{
    static string AskName()
    {
        Console.Write("Please enter youre name: ");
        string name = Console.ReadLine();
        
        return name;
    }
    static void CheckString(string str)
    {
        bool isCorect = str.All(char.IsLetter);
        if (isCorect)
        {
            Console.WriteLine("Hello, {0}!", str);
        }
        else
        {
            Console.WriteLine("Incorect format!");
        }
    }

    static void Main()
    {
        string name = AskName();
        CheckString(name);
    }
}


