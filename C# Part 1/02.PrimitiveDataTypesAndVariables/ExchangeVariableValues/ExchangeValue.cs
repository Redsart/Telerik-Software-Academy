//Problem 9. Exchange Variable Values

//Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
//Print the variable values before and after the exchange.

using System;
class ExchangeValue
{
    static void Main(string[] args)
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("Integer a="+a +", integer b="+b);
        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine("After exchange integer a="+a+", integer b="+b);
    }
}

