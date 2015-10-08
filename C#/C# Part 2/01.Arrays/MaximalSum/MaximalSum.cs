//Problem 8. Maximal sum

//Write a program that finds the sequence of maximal sum in given array.

//Example:input {2, 3, -6, -1, 2, -1, 6, 4, -8, 8 },	 result {2, -1, 6, 4}
using System;

class MaximalSum
{
    static void Main(string[] args)
    {
        Console.Write("Please enter array lenght: ");
        int arrayLenght = int.Parse(Console.ReadLine());
        int[] arr = new int[arrayLenght];

        for (int i = 0; i < arrayLenght; i++)
        {
            Console.Write("arr[{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        int currSum = arr[0];
        int startIndex = 0;
        int endIndex = 0;
        int tempIndex = 0;
        int maxSum = arr[0];
        for (int i = 0; i < arrayLenght; i++)

        {
        if (currSum <= 0)
        {
            startIndex = i;
            currSum = 0;
        }
            currSum += arr[i];
            if (currSum > maxSum)
            {
                maxSum = currSum;
                tempIndex = startIndex;
                endIndex = i;
            }
        }
        Console.Write("The best sequance is: ");

        for (int i = startIndex; i <= endIndex; i++)
            {
            Console.Write(arr[i] + " ");
            }

        Console.WriteLine();
        Console.WriteLine("The max sum is: {0}", maxSum);
    }
}

