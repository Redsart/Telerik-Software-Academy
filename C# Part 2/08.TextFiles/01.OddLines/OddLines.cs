//Problem 1. Odd lines

//Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.Text;
using System.IO;

namespace OddLines
{
    class OddLines
    {
        static void Main(string[] args)
        {
            
            StreamReader reader = new StreamReader("someText.txt", Encoding.UTF8);
            
            using (reader)
            {
                int lineNumber = 1;
                string line = reader.ReadLine();

                while (line!=null)
                {
                    lineNumber++;
                    line = reader.ReadLine();

                    if (lineNumber%2==0)
                    {
                        Console.WriteLine("{0}: {1}", lineNumber, line);
                    }
                }
            }
        }
    }
}
