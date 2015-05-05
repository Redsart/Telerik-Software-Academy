//Problem 3. English digit

//Write a method that returns the last digit of given integer as an English word.

using System;

class EnglishDigit
{
    static string GetDigit(int number)
    {
        string lastDigit = number.ToString();
        int lenght = lastDigit.Length;
        lastDigit = lastDigit.Substring(lenght - 1);

        switch(lastDigit)
        {
            case "0":
            lastDigit = "Zero";
            break;
            case "1":
            lastDigit = "One";
            break;
            case "2":
            lastDigit="Two";
            break;
            case "3":
            lastDigit="Three";
            break;
            case "4":
            lastDigit="Four";
            break;
            case "5":
            lastDigit="Five";
            break;
            case "6":
            lastDigit="Six";
            break;
            case "7":
            lastDigit="Seven";
            break;
            case "8":
            lastDigit="Eight";
            break;
            case "9":
            lastDigit="Nine";
            break;

            default:
            break;
        }
        return lastDigit;
    }
    static void Main()
    {
        Console.Write("Please enter number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(GetDigit(number));
    }
}

