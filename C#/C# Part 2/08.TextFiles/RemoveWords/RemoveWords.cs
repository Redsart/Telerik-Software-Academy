//Problem 12. Remove words

//Write a program that removes from a text file all words listed in given another text file.
//Handle all possible exceptions in your methods.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;

namespace RemoveWords
{
    class RemoveWords
    {
        static void Main(string[] args)
        {
            try
            {
                string allLines = String.Join(" ", File.ReadAllLines(@"..\..\secondfile.txt"));
                string[] allWords = allLines.Split(' ');
                using (StreamReader start = new StreamReader(@"..\..\mainfile.txt"))
                {
                    string line = start.ReadLine();
                    using (StreamWriter finish = new StreamWriter(@"..\..\finish.txt"))
                    {
                        while (line != null)
                        {
                            for (int i = 0; i < allWords.Length; i++)
                            {
                                string word = "\\b" + allWords[i] + "\\b";
                                line = Regex.Replace(line, word, "");
                            }
                            finish.WriteLine(line);
                            line = start.ReadLine();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("{0}:{1}", e.GetType().Name, e.Message);
            }
            Console.WriteLine("Deleting duplicated words was succesful.");
        }
    }
}
