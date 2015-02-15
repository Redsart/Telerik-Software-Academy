//Problem 7. Quotes in Strings

//Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
//Do the above in two different ways - with and without using quoted strings.
//Print the variables to ensure that their value was correctly defined.

using System;

class QuotedString
{
    static void Main()
    {
        string quoted = @"The ""use"" of quotations causes difficulties.";
        string withoutQuoted = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine("The string using @: " + quoted);
        Console.WriteLine("The string using escaping: " + withoutQuoted);
    }
}

