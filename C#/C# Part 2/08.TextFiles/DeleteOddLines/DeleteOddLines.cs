//Problem 9. Delete odd lines

//Write a program that deletes from given text file all odd lines.
//The result should be in the same file.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DeleteOddLines
{
    class DeleteOddLines
    {
        static void Main(string[] args)
        {
            StreamReader text = new StreamReader(@"..\..\text.txt");
            
            using (text)
            {
                int lineNumber = 0;
                string line = text.ReadLine();

                while (line!=null)
                {
                    lineNumber++;
                    line = text.ReadLine();

                    if (lineNumber%2==0)
                    {
                        Console.WriteLine("{0} {1}",lineNumber,line);
                    }

                    else
                    {
                        line=line.Remove(lineNumber);
                    }
                }
            }
        }
    }
}
