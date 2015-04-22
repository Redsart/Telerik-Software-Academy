//Problem 5. Maximal increasing sequence

//Write a program that finds the maximal increasing sequence in an array.

using System;

class MaximalIncreasingSequence
{
    static void Main()
    {
        Console.Write("Enter lenght: ");
        int arrayLenght = int.Parse(Console.ReadLine());
        int[] array = new int[arrayLenght];

        for (int i = 0; i < arrayLenght; i++)
        {
            Console.Write("Please enter integer for the array: ");
            array[i] = int.Parse(Console.ReadLine());
        }
        int sequenceLenght = 0;
        int sequencePossition = 0;
        int currentSequenceLenght = 1;
        int currentSequencePossition = 0;

        for (int i = 1; i < arrayLenght; i++)
        {
            if (array[i] > array[i - 1])
            {
                currentSequenceLenght++;
            }
            else
            {
                if (currentSequenceLenght > sequenceLenght)
                {
                    sequenceLenght = currentSequenceLenght;
                    sequencePossition = currentSequencePossition;
                }
                currentSequenceLenght = 1;
                currentSequencePossition = i;
            }
        }
        for (int i = 0; i < sequenceLenght; i++)
        {
            Console.Write("{0}, ", array[sequencePossition+i]);

        }
        Console.WriteLine();
    }
}

