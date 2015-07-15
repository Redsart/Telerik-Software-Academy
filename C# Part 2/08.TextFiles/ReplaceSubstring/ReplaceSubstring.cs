//Problem 7. Replace sub-string

//Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
//Ensure it will work with large files (e.g. 100 MB).

using System;
using System.Collections.Generic;
using System.IO;

namespace ReplaceSubstring
{
    class ReplaceSubstring
    {
        static void Main(string[] args)
        {
            StreamReader text = new StreamReader(@"..\..\text.txt");
            using (text)
            {
                StreamWriter writer = new StreamWriter(@"..\..\result.txt");

                using (writer)
                {

                    for (string line = text.ReadLine(); line != null;line=text.ReadLine())
                    {
                        string newLine = line.Replace("start","finish");
                        writer.WriteLine(newLine);

                    }
                }
            }
            Console.WriteLine("Repclacing done!");
        }
    }
}
