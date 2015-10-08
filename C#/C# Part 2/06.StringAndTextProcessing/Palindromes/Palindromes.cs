//Problem 20. Palindromes

//Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.

using System;
using System.Collections.Generic;

namespace Palindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            List<char> punctuation = new List<char>();

            for (int i = 0; i < 128; i++)
            {

                if (char.IsPunctuation((char)i))
                {
                    punctuation.Add((char)i);
                }
            }
            punctuation.Add((char)32);

            string[] words = text.Split(punctuation.ToArray(), StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("Palindromes: ");

            foreach (string word in words)
            {
                bool isPalindrome = true;

                for (int i = 0; i < word.Length / 2; i++)
                {

                    if (word[i] != word[word.Length - 1 - i])
                    {
                        isPalindrome = false;
                        break;
                    }
                }

                if (isPalindrome && word.Length > 1)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
