//Problem 2. Concatenate text files

//Write a program that concatenates two text files into another text file.

using System;
using System.Text;
using System.IO;

namespace ConcatenateTextFiles
{
    class ConcatenateTextFiles
    {
        static void Main(string[] args)
        {
            using (StreamWriter writer = new StreamWriter(@"..\..\text.txt", true))
            {

                using (StreamReader firstReader = new StreamReader(@"..\..\text1.txt"))
                {
                    string line = firstReader.ReadLine();

                    while (line!=null)
                    {
                        writer.WriteLine(line);
                        line = firstReader.ReadLine();
                    }
                }

                using (StreamReader secondReader=new StreamReader(@"..\..\text2.txt"))
                {
                    string line = secondReader.ReadLine();

                    while (line!=null)
                    {
                        writer.WriteLine(line);
                        line = secondReader.ReadLine();
                    }
                }
            }

            Console.WriteLine("Concatenation is completed!");
        }
    }
}
