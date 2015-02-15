//Problem 2. Gravitation on the Moon

//The gravitational field of the Moon is approximately 17% of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

using System;

class ManOnTheMoon
{
    static void Main()
    {
        Console.Write("Weight on the Earth: ");
        double weight=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Weight on the Moon: " + (weight * 0.17));
    }
}

