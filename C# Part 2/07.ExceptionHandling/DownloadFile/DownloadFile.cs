//Problem 4. Download file

//Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
//Find in Google how to download files in C#.
//Be sure to catch all exceptions and to free any used resources in the finally block.

using System;
using System.Net;

namespace DownloadFile
{
    class DownloadFile
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter web path: ");
                string address = Console.ReadLine();
                Console.Write("Enter the name of the file: ");
                string fileName = Console.ReadLine();
                WebClient myWebClient = new WebClient();
                string myStringWebResource = address + fileName;
                myWebClient.DownloadFile(myStringWebResource,fileName);
                Console.WriteLine("Image was downloaded successfully in 'bin' directory of the project!");
            }

            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (WebException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.WriteLine("Goodbye!");
            }
        }
    }
}
