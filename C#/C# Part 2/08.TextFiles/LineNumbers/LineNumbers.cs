//Problem 3. Line numbers

//Write a program that reads a text file and inserts line numbers in front of each of its lines.
//The result should be written to another text file

using System;
using System.IO;

namespace LineNumbers
{
    class LineNumbers
    {
        static void Main(string[] args)
        {
            using (StreamWriter write=new StreamWriter(@"..\..\finalText.txt",true))
            {

                using (StreamReader reader=new StreamReader(@"..\..\someText.txt"))
                {
                    string line = reader.ReadLine();
                    int lineNumber = 0;

                    while (line!=null)
                    {
                        lineNumber++;
                        write.WriteLine("{0} {1}",lineNumber,line);
                        line = reader.ReadLine();
                    }
                }

                Console.WriteLine("Proces is completed!");
            }
        }
    }
}
