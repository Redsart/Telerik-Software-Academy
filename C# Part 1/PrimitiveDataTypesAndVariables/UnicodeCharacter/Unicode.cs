//Problem 4. Unicode Character

//Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) using the \u00XX syntax, and then print it.

using System;

class Unicode
{
    static void Main()
    {
        char uni= '\u002A';
        Console.WriteLine("Unicode of 42 is: "+ uni);
    }
}

