//Problem 8. Replace whole word

//Modify the solution of the previous problem to replace only whole words (not strings).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ReplaceWholeWord
{
    class ReplaceWholeWord
    {
        static void Main(string[] args)
        {
            StreamReader text = new StreamReader(@"..\..\text.txt");

            using (text)
            {
                StreamWriter writer = new StreamWriter(@"..\..\replacedText.txt");
                
                using (writer)
                {

                    for (string line = text.ReadLine(); line != null;line=text.ReadLine())
                    {
                        char sign = line[line.Length - 1];
                        line = line.Remove(line.Length - 1);
                        string[] words = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                        Array.Reverse(words);
                        string.Join(" ", words);
                    }
                }
            }
            Console.WriteLine("Words are replaced!");
        }
    }
}
