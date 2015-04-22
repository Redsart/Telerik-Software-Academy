//Problem 3. Compare char arrays

//Write a program that compares two char arrays lexicographically (letter by letter).

using System;
using System.Linq;


class CompareCharArrays
{
    static void Main()
    {
        Console.Write("Please enter the lenght of first array: ");
        int firstCharArray = int.Parse(Console.ReadLine());
        Console.Write("Please enter the lenght of second array: ");
        int secondCharArray = int.Parse(Console.ReadLine());

        char[] arr1=  new char[firstCharArray];
        char[] arr2 = new char[secondCharArray];
        

        for (int i = 0; i < firstCharArray; i++)
        {
            Console.Write("Please enter a char for first array: ");
            arr1[i] = char.Parse(Console.ReadLine());
            Console.WriteLine(arr1[i]);
        }
        for (int i = 0; i < secondCharArray; i++)
        {
            Console.WriteLine();
            Console.Write("Please enter a char for second array: ");
            arr2[i] = char.Parse(Console.ReadLine());
        }

        if (arr1.Length > arr2.Length)
        {
            Console.WriteLine("The first array has a bigger lenght.");
        }
        else if (arr1.Length < arr2.Length)
        {
            Console.WriteLine("The second array has a bigger lenght.");
        }
        else
        {
            Console.WriteLine("The arrays are equal lenght's.");

            if (arr1.Where((t, i) => t != arr2[i]).Any())
            {
                Console.WriteLine("but different elements.");
                return;
            }
            Console.WriteLine("Elements are equal.");
        }
    }
}

