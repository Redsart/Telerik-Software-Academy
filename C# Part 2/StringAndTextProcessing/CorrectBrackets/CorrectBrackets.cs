//Problem 3. Correct brackets

//Write a program to check if in a given expression the brackets are put correctly.

//Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).
using System;

namespace CorrectBrackets
{
    class CorrectBrackets
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an expression: ");
            string expression = Console.ReadLine();

            Console.WriteLine(BracketsAreCorrect(expression) ? "CORRECT" : "INCORRECT");
        }

        private static bool BracketsAreCorrect(string expression)
        {
            int bracketCount = 0;

            foreach (var letter in expression)
            {
                if (letter == '(')
                    ++bracketCount;
                else if (letter == ')')
                    --bracketCount;

                if (bracketCount < 0)
                    return false;
            }

            return bracketCount == 0;
        }
    }
}
