//Problem 10. Unicode characters

//Write a program that converts a string to a sequence of C# Unicode character literals.
//Use format strings.

using System;
using System.Text;

namespace UnicodeCharacter
{
    class UnicodeCharacter
    {
        static void Main(string[] args)
        {
            Console.Write("Enter some text: ");
            string str = Console.ReadLine();
            byte[] uniByte = Encoding.Unicode.GetBytes(str);
            string uniString = string.Empty;
            foreach (byte b in uniByte)
            {
                if (b == 0)
                {
                    continue;
                }
                uniString += string.Format("{0}{1}", "\\u",b.ToString("X").PadLeft(4,'0'));
            }
            Console.WriteLine(uniString);
        }
    }
}
