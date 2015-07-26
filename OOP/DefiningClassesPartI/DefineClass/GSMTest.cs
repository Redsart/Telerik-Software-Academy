using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefineClass
{
    public class GSMTest
    {
        public static Random rnd = new Random();

        public static string[,] manufactureAndModel =
        {
            {"Nokia", "Samsung", "LG", "HTC"},
            {"Lumia", "Galaxy", "G3", "One"},
            {"3310", "One note", "Magna","Desire"},
            {"Asha", "Z1", "Optimus", "Butterfly"}
        };

        public static string[] Owners =
        {
            "Martin", "Krasimir", "Georgi", "Evgeni"
        };

        public static Battery[] batteries =
        {
            new Battery(),new Battery("Better",250,25,BatteryType.LiIon),
            new Battery("Bad",50,5,BatteryType.NiCd),new Battery("Test",300,30,BatteryType.NiMH)
        };

        public static Display[] displays =
        {
            new Display(),new Display(4,2500),new Display(4.5,16000)
        };

        public static GSM[] GenerateGsms(int number)
        {
            GSM[] gsms=new GSM[number];
            for (int i = 0; i < number; i++)
            {
                int col = rnd.Next(0,manufactureAndModel.GetLength(1));
                int row = rnd.Next(1,manufactureAndModel.GetLength(0));

                gsms[i] = new GSM(manufactureAndModel[0, col], manufactureAndModel[col, row], Owners[rnd.Next(0, Owners.Length)], rnd.Next(1, 2001),
                    batteries[rnd.Next(0,batteries.Length)],displays[rnd.Next(0,displays.Length)],new List<Call>());
            }
            return gsms;
        }

        public static void PrintGSMInfo(GSM[] gsms)
        {
            for (int i = 0; i < gsms.Length; i++)
            {
                Console.WriteLine("Sample GSM {0}: {1}", i + 1, gsms[i]);
                Console.WriteLine(new string('-', 50));
            }

            Console.WriteLine("IPhone info: {0}", GSM.Iphone4S);
        }
    }
}
