//Problem 19. Dates from text in Canada

//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
//Display them in the standard date format for Canada.

using System;
using System.Text.RegularExpressions;
using System.Globalization;

namespace DatesFromTextInCanada
{
    class DatesFromTextInCanada
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {

                if (Regex.IsMatch(words[i], @"\b\d{1,2}\.\d{1,2}.\d{4}"))
                {

                    if (Regex.IsMatch(words[i], @"..$"))
                    {
                        words[i] = words[i].Remove(words[i].Length - 1);
                    }

                    DateTime date = DateTime.ParseExact(words[i], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                    Console.WriteLine(date.ToShortDateString().ToString(new CultureInfo("en-CA")));
                }
            }
        }
    }
}
