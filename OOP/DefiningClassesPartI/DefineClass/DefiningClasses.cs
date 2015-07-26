//Problem 1. Define class

//Define a class that holds information about a mobile phone device: model, manufacturer, price, owner, battery characteristics (model, 
//hours idle and hours talk) and display characteristics (size and number of colors).
//Define 3 separate classes (class GSM holding instances of the classes Battery and Display).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefineClass
{
    class DefiningClasses
    {
        static void Main(string[] args)
        {
            GSMTest.PrintGSMInfo(GSMTest.GenerateGsms(3));
            Console.WriteLine(new string('-',50));

            GSMCallHistoryTest.CreateCallHistory();
            GSMCallHistoryTest.DisplayCallTestHistory();
            Console.WriteLine(new string('-',50));
            GSMCallHistoryTest.CalculateAndPrintTestCallPrice();
            GSMCallHistoryTest.RemoveLongestCall();
            Console.WriteLine(new string('-',50));
            Console.WriteLine("{0}/n Price after longest call is removed",new string('-',50));
            GSMCallHistoryTest.CalculateAndPrintTestCallPrice();
            Console.WriteLine(new string('-',50));
            Console.WriteLine("{0}/n Price after longest call is removed", new string('-', 50));
            GSMCallHistoryTest.DisplayCallTestHistory();
            Console.WriteLine(new string('-',50));
            GSMCallHistoryTest.TestGSM.ClearCallsHistory();
            Console.WriteLine("{0}\n{1}", "Call history list is cleared...", new string('-', 50));
            GSMCallHistoryTest.DisplayCallTestHistory();
        }
    }
}
