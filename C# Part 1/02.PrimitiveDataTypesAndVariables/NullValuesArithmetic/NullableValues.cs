﻿//Problem 12. Null Values Arithmetic

//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.

using System;

class NullableValues
{
    static void Main(string[] args)
    {
        int? nullableInteger = null;
        double? nullableDouble = null;
        Console.WriteLine("Integer with value null: "+nullableInteger);
        Console.WriteLine("Double with value null: "+nullableDouble);
        nullableInteger = 5;
        nullableDouble=10.5;
        Console.WriteLine("Integer with new value: " + nullableInteger);
        Console.WriteLine("Double with new value: "+nullableDouble);
    }
}

