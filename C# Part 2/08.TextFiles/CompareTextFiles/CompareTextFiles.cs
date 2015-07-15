//Problem 4. Compare text files

//Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that 
//are different.
//Assume the files have equal number of lines.

using System;
using System.Collections.Generic;
using System.IO;

namespace CompareTextFiles
{
    class CompareTextFiles
    {
        static void Main(string[] args)
        {
            StreamReader firstReader = new StreamReader(@"..\..\text1.txt");
            StreamReader secondReader = new StreamReader(@"..\..\text2.txt");
            
            using (firstReader)
            {

                using (secondReader)
                {
                    string firstTextLine = firstReader.ReadLine();
                    string secondTextLine = secondReader.ReadLine();
                    int count = 1;
                    List<int> sameLines=new List<int>();
                    List<int> differentLines=new List<int>();

                    while (firstTextLine!=null)
                    {

                        if (firstTextLine.Equals(secondTextLine))
                        {
                            sameLines.Add(count);
                        }

                        else
                        {
                            differentLines.Add(count);
                        }

                        count++;
                        firstTextLine = firstReader.ReadLine();
                        secondTextLine = secondReader.ReadLine();
                    }

                    Console.WriteLine("Same lines: {0}", string.Join(" ", sameLines));
                    Console.WriteLine("Different lines: {0}", string.Join(" ", differentLines));
                }
            }
        }
    }
}
