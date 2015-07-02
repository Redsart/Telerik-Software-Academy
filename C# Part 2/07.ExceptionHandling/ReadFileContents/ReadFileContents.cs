//Problem 3. Read file contents

//Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
//Find in MSDN how to use System.IO.File.ReadAllText(…).
//Be sure to catch all possible exceptions and print user-friendly error messages.

using System;
using System.IO;

namespace ReadFileContents
{
    class ReadFileContents
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter file path (e.g. C:\\WINDOWS\\win.ini): ");
                string filePath = Console.ReadLine();

                string readText = File.ReadAllText(filePath);
                Console.WriteLine(readText);
            }

            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Youre path is not full, check for something you forget (e.g. .txt)!");
            }

            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Wrong directory. Maybe you use / instead of \\!");
            }

            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found. Check youre extension!");
            }

        }
    }
}
