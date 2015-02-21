//Problem 3. Check for a Play Card

//Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A.
//Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise.
using System;

class ChekPlayCard
{
    static void Main()
    {
        Console.Write("Check for play card: ");
        string card=(Console.ReadLine());
        string[] playCard={"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
        if (Array.IndexOf(playCard, card) >= 0)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}

