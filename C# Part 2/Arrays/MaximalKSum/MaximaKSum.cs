//Problem 6. Maximal K sum

//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.

using System;

class MaximaKSum
{
    static void Main()
    {
        Console.Write("Enter array lenght: ");
        int arrayLenght = int.Parse(Console.ReadLine());
        int[] arr=new int[arrayLenght];

        for (int i = 0; i < arrayLenght; i++)
        {
            Console.Write("Please ente an integer: ");
             arr[i]=int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < arr.Length-1; i++)
        {

            for (int j = i+1; j < arr.Length; j++)
            {
                if (arr[i] > arr[j])
                {
                    int sort = arr[i];
                    arr[i] = arr[j];
                    arr[j] = sort;
                }
            }
        }
            for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("The sum of maximal K elements is {0}+{1}={2}",arr[arrayLenght-1],arr[arrayLenght-2],arr[arrayLenght-1] + arr[arrayLenght-2]);
            break;
        }
            Console.WriteLine();
    }
}

