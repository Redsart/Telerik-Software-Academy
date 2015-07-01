//Problem 12. Parse URL

//Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], 
//[server] and [resource] elements.

using System;

namespace ParseURL
{
    class ParseURL
    {
        static void Main(string[] args)
        {
            Console.Write("Enter URL address: ");
            string url = Console.ReadLine();
            int index = 0;

            index = url.IndexOf(':');
            Console.WriteLine("[protocol]: {0}",url.Substring(0,index));
            url = url.Remove(0, index+3);

            index = url.IndexOf('/');
            Console.WriteLine("[server]: {0}",url.Substring(0,index));
            url = url.Remove(0, index);

            Console.WriteLine("[resource]: {0}",url);
        }
    }
}
