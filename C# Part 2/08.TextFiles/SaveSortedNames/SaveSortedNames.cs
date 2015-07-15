//Problem 6. Save sorted names

//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.

//Example:
//input.txt 	output.txt
//Ivan          George
//Peter         Ivan
//Maria         Maria
//George        Peter

using System;
using System.Collections.Generic;
using System.IO;

namespace SaveSortedNames
{
    class SaveSortedNames
    {
        static void Main()
        {
            StreamReader text = new StreamReader(@"..\..\text.txt");
            using (text)
            {
                List<string> names = new List<string>();

                for (string current=text.ReadLine();current!=null;current=text.ReadLine())
                {
                    names.Add(current);
                }
                names.Sort();
                StreamWriter writer = new StreamWriter(@"..\..\sortedNames.txt");

                using (writer)
                {

                    foreach (var name in names)
                    {
                        writer.WriteLine(name);
                    }
                }
            }
            Console.WriteLine("Names are sorted!");
        }
    }
}
