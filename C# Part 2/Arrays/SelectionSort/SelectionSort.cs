//Problem 7. Selection sort

//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, 
//move it at the second position, etc.

using System;

class SelectionSort
{
    static void Main()
    {
        Console.Write("Please enter array lenght:");
        int arrayLenght = int.Parse(Console.ReadLine());
        int[] array = new int[arrayLenght];
        for (int i = 0; i < arrayLenght; i++)
        {
            Console.Write("Please enter an integer: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] > array[j]) 
                {
                    int sort = array[i];
                    array[i] = array[j];
                    array[j] = sort;
                }
            }
        }

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}

