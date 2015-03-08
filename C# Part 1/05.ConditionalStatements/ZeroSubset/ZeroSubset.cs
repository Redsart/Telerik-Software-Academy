//Problem 12.* Zero Subset

//We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
//Assume that repeating the same subset several times is not a problem.
//Examples:

//  numbers 	    |    result
//  3 -2 1 1 8 	    |    -2 + 1 + 1 = 0
//  3 1 -7 35 22 	|    no zero subset
//  1 3 -4 -2 -1 	|    1 + -1 = 0
//                  |    1 + 3 + -4 = 0
//                  |    3 + -2 + -1 = 0
//  1 1 1 -1 -1 	|    1 + -1 = 0
//                  |    1 + 1 + -1 + -1 = 0
//  0 0 0 0 0 	    |    0 + 0 + 0 + 0 + 0 = 0


using System;

class ZeroSubset
{
    static void Main()
    {
        Console.WriteLine("This program finds all subsets of these numbers whose sum is 0.");

        Console.Write("Please enter first number: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Please enter second number: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Please enter third number: ");
        int c = int.Parse(Console.ReadLine());

        Console.Write("Please enter fourth number: ");
        int d = int.Parse(Console.ReadLine());

        Console.Write("Please enter fifth number: ");
        int e = int.Parse(Console.ReadLine());
        bool hasSubset = false;

        if (a + b == 0)
        {
            Console.WriteLine("{0}+{1}=0",a,b);
            hasSubset = true;
        }
        if (a + c == 0)
        {
            Console.WriteLine("{0}+{1}=0",a,c);
            hasSubset = true;
        }
        if (a + d == 0)
        {
            Console.WriteLine("{0}+{1}=0",a,d);
            hasSubset = true;
        }
        if (a + e == 0)
        {
            Console.WriteLine("{0}+{1}=0",a,e);
            hasSubset = true;
        }
        if (b + c == 0)
        {
            Console.WriteLine("{0}+{1}=0",b,c);
            hasSubset = true;
        }
        if (b + d == 0)
        {
            Console.WriteLine("{0}+{1}=0",b,d);
            hasSubset = true;
        }
        if (b + e == 0)
        {
            Console.WriteLine("{0}+{1}=0",b,e);
            hasSubset = true;
        }
        if (c + d == 0)
        {
            Console.WriteLine("{0}+{1}=0",c,d);
            hasSubset = true;
        }
        if (c + e == 0)
        {
            Console.WriteLine("{0}+{1}=0",c,e);
            hasSubset = true;
        }
        if (d + e == 0)
        {
            Console.WriteLine("{0}+{1}=0",d,e);
            hasSubset = true;
        }
        if (a + b + c == 0)
        {
            Console.WriteLine("{0}+{1}+{2}=0",a,b,c);
            hasSubset = true;
        }
        if (a + b + d == 0)
        {
            Console.WriteLine("{0}+{1}+{2}=0",a,b,d);
            hasSubset = true;
        }
        if (a + b + e == 0)
        {
            Console.WriteLine("{0}+{1}+{2}=0",a,b,e);
            hasSubset = true;
        }
        if (a + c + d == 0)
        {
            Console.WriteLine("{0} + {1} + {2}=0",a,c,d);
            hasSubset = true;
        }
        if (a + c + e == 0)
        {
            Console.WriteLine("{0}+{1}+{2}=0",a,c,e);
            hasSubset = true;
        }
        if (a + d + e == 0)
        {
            Console.WriteLine("{0}+{1}+{2}=0",a,d,e);
            hasSubset = true;
        }
        if (b + c + d == 0)
        {
            Console.WriteLine("{0}+{1}+{2}=0",b,c,d);
            hasSubset = true;
        }
        if (b + c + e == 0)
        {
            Console.WriteLine("{0}+{1}+{2}=0",b,c,e);
            hasSubset = true;
        }
        if (b + d + e == 0)
        {
            Console.WriteLine("{0}+{1}+{2}=0",b,d,e);
            hasSubset = true;
        }
        if (c + d + e == 0)
        {
            Console.WriteLine("{0}+{1}+{2}=0",c,d,e);
            hasSubset = true;
        }
        if (a + b + c + d == 0)
        {
            Console.WriteLine("{0}+{1}+{2}+{3}=0",a,b,c,d);
            hasSubset = true;
        }
        if (a + b + c + e == 0)
        {
            Console.WriteLine("{0}+{1}+{2}+{3}=0",a,b,c,e);
            hasSubset = true;
        }
        if (b + c + d + e == 0)
        {
            Console.WriteLine("{0}+{1}+{2}+{3}=0",b,c,d,e);
            hasSubset=true;
        }
        if (a + b + c + d + e == 0)
        {
            Console.WriteLine("{0}+{1}+{2}+{3}+{4}=0",a,b,c,d,e);
            hasSubset = true;
        }
        if (!hasSubset)
        {
            Console.WriteLine("No zero subset");
        }
    }
}

