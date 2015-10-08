//Problem 1. StringBuilder.Substring

//Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and has the same 
//functionality as Substring in the class String.

using System;
using System.Text;

namespace StringBuilderSubstring
{
    class StringBuilderSubstringMain
    {
        static void Main(string[] args)
        {
            StringBuilder testStringBuilder = new StringBuilder("Some text for test.");

            StringBuilder testStringBuilder1 = testStringBuilder.Substring(2, 4);
            StringBuilder testStringBuilder2 = StringBuilderSubstr.Substring(testStringBuilder, 2, 4);
            StringBuilder testStringBuilder3 = testStringBuilder.Substring(15);
            StringBuilder testStringBuilder4 = StringBuilderSubstr.Substring(testStringBuilder, 15);

            Console.WriteLine("Result from tests: \n(same1){0}, \n(same1){1}, \n(same2){2}, \n(same2){3}"
                ,testStringBuilder1, testStringBuilder2, testStringBuilder3, testStringBuilder4);
        }
    }
}
