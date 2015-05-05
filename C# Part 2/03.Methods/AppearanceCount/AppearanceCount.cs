//Problem 4. Appearance count

//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.

using System;

class AppearanceCount
{
    static void Main()
    {
        int[] array = { 1, 2, 1, 5, 4, 8, 5, 2, 1, 4, 6, 3 };
        Console.WriteLine("Please enter number: ");
        int number = int.Parse(Console.ReadLine());
        int count = CountRepeatability(array, number);
        Console.WriteLine("{0} appears {1} times in the array", number, count);
    }

    static int CountRepeatability(int[] array, int number)
    {
        int counter = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number)
            {
                counter++;
            }
        }
        return counter;
    }
}

