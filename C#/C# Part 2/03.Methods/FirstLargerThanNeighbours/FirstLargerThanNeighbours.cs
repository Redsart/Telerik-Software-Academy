//Problem 6. First larger than neighbours

//Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
//Use the method from the previous exercise.

using System;

class FirstLargerThanNeighbours
{
    static void Main()
    {
        int[] array = { 2, 7, 14, 66, 52, 24, 25 };
        int position = CheckNeighbours(array);
        if (position > 0)
        {
            Console.WriteLine("The element is on position " + position);
        }
        else
        {
            Console.WriteLine("No such element exists!");
        }
    }

    static int CheckNeighbours(int[] array)
    {
        int position;
        position = -1;
        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i] > array[i - 1] && array[i] > array[i + 1])
            {
                position = i;
                break;
            }
        }
        return position;
    }
}

