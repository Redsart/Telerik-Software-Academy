//Problem 5. Larger than neighbours

//Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).

using System;

class LargerThanNeighbours
{
    static void Main()
    {
        int[] array = { 2, 7, 14, 66, 52, 24, 25 };
        int position = int.Parse(Console.ReadLine());
        if (CheckNeighbours(array, position))
        {
            Console.WriteLine("{0} is greater than {1} and {2} ", array[position], array[position - 1], array[position + 1]);
        }
        else
        {
            Console.WriteLine("{0} is not greater than {1} and {2} ", array[position], array[position - 1], array[position + 1]);
        }
    }

    static bool CheckNeighbours(int[] array, int position)
    {
        bool isGreater = false;
        if (position < array.Length && position > 0)
        {
            if (array[position] > array[position - 1] && array[position] > array[position + 1]) 
            {
                isGreater = true;
            }
        }
        else
        {
            Console.WriteLine("There are no neighbours to compare!");
            Environment.Exit(1);
        }
        return isGreater;
    }
}

