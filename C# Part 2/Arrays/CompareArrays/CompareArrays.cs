//Problem 2. Compare arrays

//Write a program that reads two integer arrays from the console and compares them element by element.

using System;
using System.Linq;

class CompareArrays
{
    static void Main()
    {
        Console.Write("Please enter a positive integer: ");
        int first = int.Parse(Console.ReadLine());
        Console.Write("Please enter another positive integer: ");
        int second = int.Parse(Console.ReadLine());

        int[] arr1 = new int[first];
        int[] arr2=new int[second];
        
            
        for (int i = 0; i < first; i++)
        {
            Console.Write("Please enter a integer for first array: ");
            arr1[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < second; i++)
        {
            Console.WriteLine();
            Console.Write("Please enter a integer for second array: ");
            arr2[i] = int.Parse(Console.ReadLine());
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

