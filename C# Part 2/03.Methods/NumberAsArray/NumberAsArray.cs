//Problem 8. Number as array

//Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
//Each of the numbers that will be added could have up to 10 000 digits.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class NumberAsArray
{
    static void Main()
    {
        PrintResult(Add(new byte[] { 3, 6, 1 }, new byte[] { 7, 2, 5 }));
        PrintResult(Add(new byte[] { 8, 9, 9 }, new byte[] { 1 }));
        PrintResult(Add(new byte[] { 1 }, new byte[] { 9, 9 }));
    }

    static byte[] Add(byte[] a, byte[] b)
    {
        if (a.Length > b.Length)
        {
            return Add(b, a);
        }
        PrintResult(a);
        PrintResult(b);
        byte[] result = new byte[b.Length + 1];
        int i = 0;
        int carry = 0;
        for (; i < a.Length; i++)
        {
            result[i] = (byte)(a[i] + b[i] + carry);
            carry = result[i] / 10;
            result[i] %= 10;
        }
        for (; i < b.Length && carry != 0; i++)
        {
            result[i] = (byte)(b[i] + carry);
            carry = result[i] / 10;
            result[i] %= 10;
        }
       
        for (; i < b.Length; i++)
        {
            result[i] = b[i];
        }
        
        if (carry != 0)
        {
            result[i] = 1;
        }
        else
        {
            Array.Resize(ref result, result.Length - 1); 
        }
        return result;
    }

    static void PrintResult(byte[] array)
    {
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Console.Write(array[i]);
        }
        Console.WriteLine();
    }
}

