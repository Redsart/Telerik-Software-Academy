//Problem 9. Frequent number

//Write a program that finds the most frequent number in an array.

//Example:input {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}, 	result{4 (5 times)}
using System;

class FrequentNumber
{
    static void Main()
    {
        Console.Write("Please enter array lenght: ");
        int arrayLenght = int.Parse(Console.ReadLine());
        int[] arr = new int[arrayLenght];

        for (int i = 0; i < arrayLenght; i++)
        {
            Console.Write("arr[{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        int count = 1;
        int maxCount = 1;
        int countedNum = 0;
        Array.Sort(arr);

            for (int i = 0; i < arrayLenght - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
            count++;
            }
                else
                {
                count = 1;
                }

            if (count > maxCount)
            {
                maxCount = count;
                countedNum = arr[i];
            }
        }

        if (maxCount > 1)
        {
        Console.WriteLine("Most frequant number is {0} and it is counted {1} times.", countedNum, maxCount);
        }
        else
        {
        Console.WriteLine("No frequancy!");
        }
    }
}

