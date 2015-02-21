using System;
//Problem 9. Print a Sequence

//Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

class Sequence
{
    static void Main()
    {
        for (int i = 2; i <= 10; )
        {
            Console.WriteLine(i++);
            Console.WriteLine(-i++);
        }
    }
}

