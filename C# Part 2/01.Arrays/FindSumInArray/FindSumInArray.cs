//Problem 10. Find sum in array

//Write a program that finds in given array of integers a sequence of given sum S (if present).

//Example: array {4, 3, 1, 4, 2, 5, 8}, S {11}, result {4, 2, 5}
using System;

class FindSumInArray
{
    static void Main()
    {
        Console.Write("Please enter array lenght: ");
        int arrayLenght = int.Parse(Console.ReadLine());
        int[] arr = new int[arrayLenght];

        Console.Write("Enter Sum: ");
        int sum = int.Parse(Console.ReadLine());

            for (int i = 0; i < arrayLenght; i++)
            {
            Console.Write("arr[{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
            }

        int currSum = 0;
        int startIndex = 0;

        for (int i = 0; i < arrayLenght - 1; i++)
        {
        currSum += arr[i];
        startIndex = i;
            for (int j = i + 1; j < arrayLenght; j++)
        {
            currSum += arr[j];
            if (currSum == sum)
        {
                for (int k = startIndex; k <= j; k++)
                {
                    Console.WriteLine("{0} ", arr[k]);
                }
            break;
        }
        }
        currSum = 0;
        }
    }
}

