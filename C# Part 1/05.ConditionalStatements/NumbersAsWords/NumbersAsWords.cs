//Problem 11.* Number as Words

//Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.
//Examples:
//  numbers 	|    number as words
//  0 	        |    Zero
//  9 	        |    Nine
//  10 	        |    Ten
//  12 	        |    Twelve
//  19 	        |    Nineteen
//  25 	        |    Twenty five
//  98 	        |    Ninety eight
//  273 	    |    Two hundred and seventy three
//  400 	    |    Four hundred
//  501 	    |    Five hundred and one
//  617 	    |    Six hundred and seventeen
//  711 	    |    Seven hundred and eleven
//  999 	    |    Nine hundred and ninety nine

using System;

class NumbersAsWords
{
    static string Units(int number, bool showZero)
    {
        string result = "";
        switch (number)
        {
            case 0:
                result = "Zero";
                break;
            case 1:
                result = "One";
                break;
            case 2:
                result = "Two";
                break;
            case 3:
                result = "Three";
                break;
            case 4:
                result = "Four";
                break;
            case 5:
                result = "Five";
                break;
            case 6:
                result = "Six";
                break;
            case 7:
                result = "Seven";
                break;
            case 8:
                result = "Eight";
                break;
            case 9:
                result = "Nine";
                break;
        }
        if (!showZero && result == "Zero")
        {
            result = "";
        }
        return result;
    }

    static string TenToNineteen(int number)
    {
        string result = "";
        switch (number)
        {
            case 10:
                result = "Ten";
                break;
            case 11:
                result = "Eleven";
                break;
            case 12:
                result = "Twelve";
                break;
            case 13:
                result = "Thirteen";
                break;
            case 14:
                result = "Fourteen";
                break;
            case 15:
                result = "Fifteen";
                break;
            case 16:
                result = "Sixteen";
                break;
            case 17:
                result = "Seventeen";
                break;
            case 18:
                result = "Eighteen";
                break;
            case 19:
                result = "Nineteen";
                break;
        }
        return result;
    }

    static string Tenths(int number)
    {
        string result = "";
        switch (number)
        {
            case 2:
                result = "Twenty ";
                break;
            case 3:
                result = "Thirty ";
                break;
            case 4:
                result = "Forty ";
                break;
            case 5:
                result = "Fifty ";
                break;
            case 6:
                result = "Sixty ";
                break;
            case 7:
                result = "Seventy ";
                break;
            case 8:
                result = "Eighty ";
                break;
            case 9:
                result = "Ninety ";
                break;
        }
        return result;
    }

    static string Hundreds(int number)
    {
        string result = "";
        switch (number)
        {
            case 1:
                result = "One Hundred";
                break;
            case 2:
                result = "Two Hundred";
                break;
            case 3:
                result = "Three Hundred";
                break;
            case 4:
                result = "Four Hundred";
                break;
            case 5:
                result = "Five Hundred";
                break;
            case 6:
                result = "Six Hundred";
                break;
            case 7:
                result = "Seven Hundred";
                break;
            case 8:
                result = "Eight Hundred";
                break;
            case 9:
                result = "Nine Hundred";
                break;
        }
        return result;
    }

    static void Main()
    {
        Console.Write("Please enter a number between 0-999: ");
        int number = int.Parse(Console.ReadLine());
        if (number<0 || number>999)
        {
            Console.WriteLine("Invalid number!");
        }
        else if (number<10)
        {
            Console.Write(number);
        }
        else if (number<20)
        {
            Console.Write(TenToNineteen(number));
        }
        else if (number<100)
        {
            Console.Write(Tenths(number / 10));
            Console.Write(Units(number % 10,false).ToLower());
        }
        else if (number < 1000)
        {
            Console.Write(Hundreds(number / 100));
            if (number % 100 < 10)
            {
                if (number % 100 != 0)
                {
                    Console.Write("and ");
                }
                Console.Write(Units(number % 100, false).ToLower());
            }
            else if (number % 100 < 20)
            {
                Console.Write("and ");
                Console.Write(TenToNineteen(number % 100).ToLower());
            }
            else
            {
                if (number / 10 % 10 != 0)
                {
                    Console.Write("and ");
                }
                Console.Write(Tenths(number / 10 % 10).ToLower());
                if (number / 10 % 10 != 0)
                {
                    Console.Write(Units(number % 10, false).ToLower());
                }
            }
        }
        Console.WriteLine();
    }
}

