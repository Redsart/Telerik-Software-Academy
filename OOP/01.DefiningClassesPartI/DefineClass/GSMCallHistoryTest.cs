using System;
using System.Collections.Generic;
using System.Linq;

namespace DefineClass
{
    public class GSMCallHistoryTest
    {
        public static GSM TestGSM = new GSM("Test GSM", "Test Model");

        public static DateTime testCall1Date = DateTime.Parse("12/07/2015 18:15:12");
        public static DateTime testCall2Date = DateTime.Parse("12/07/2015 19:01:45");
        public static DateTime testCall3Date = DateTime.Parse("14/07/2015 01:13:15");
        public static DateTime testCall4Date = DateTime.Parse("14/07/2015 12:12:12");
        public static DateTime testCall5Date = DateTime.Parse("14/07/2015 22:00:59");

        public static Call[] testCalls =
        {
            new Call(testCall1Date,"0883111222",30),
            new Call(testCall2Date,"0883222111",40),
            new Call(testCall3Date,"0883333333",50),
            new Call(testCall4Date,"0883555444",60),
            new Call(testCall5Date,"0883888999",70)
        };

        public static void CreateCallHistory()
        {
            for (int i = 0; i < testCalls.Length; i++)
            {
                TestGSM.AddCalls(testCalls[i]);
            }
        }

        public static void DisplayCallTestHistory()
        {
            Console.WriteLine(TestGSM.PrintCallHistory());
        }

        public static void CalculateAndPrintTestCallPrice()
        {
            decimal price = TestGSM.CalculateTotalPrice(0.37M);
            Console.WriteLine("Total price of calls is: {0:F2}",price);
        }

        public static void RemoveLongestCall()
        {
            Call longestCall=TestGSM.CallHistory.OrderBy(x=>x.Duration).ToArray()[TestGSM.CallHistory.Count-1];
            TestGSM.DeleteCalls(longestCall);
        }
    }
}
