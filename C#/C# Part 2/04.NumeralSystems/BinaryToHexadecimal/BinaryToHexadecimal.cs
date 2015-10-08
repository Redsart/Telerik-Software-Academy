//Problem 6. Binary to hexadecimal

//Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;

class BinaryToHexadecimal
{
    static void Main()
    {
        Console.Write("Please enter binary number:");
        int binary = int.Parse(Console.ReadLine());
        string binyryStr = binary.ToString();
        int lenght = binyryStr.Length;
        int zeroToAdd = (lenght % 4);
        switch (zeroToAdd)
        {
            case 1: zeroToAdd = 3; break;
            case 2: zeroToAdd = 2; break;
            case 3: zeroToAdd = 1; break;
            default:
                zeroToAdd = 0;
                break;
        }
        binyryStr = binyryStr.PadLeft(lenght + zeroToAdd, '0');
        string hexString;
        string result = "";
        for (int i = 0; i < binyryStr.Length; i += 4)
        {
            hexString = "";
            for (int j = i; j < 4 + i; j++)
            {
                hexString += binyryStr[j];
            }
            switch (hexString)
            {
                case "0000": result += "0"; break;
                case "0001": result += "1"; break;
                case "0010": result += "2"; break;
                case "0011": result += "3"; break;
                case "0100": result = "4"; break;
                case "0101": result += "5"; break;
                case "0110": result = "6" + result; break;
                case "0111": result = "7" + result; break;
                case "1000": result = "8" + result; break;
                case "1001": result = "9" + result; break;
                case "1010": result = "A" + result; break;
                case "1011": result = "B" + result; break;
                case "1100": result = "C" + result; break;
                case "1101": result = "D" + result; break;
                case "1110": result = "E" + result; break;
                case "1111": result = "F" + result; break;
                default:
                    break;
            }
        }
        Console.WriteLine("In Hexadecimal: {0}", result);
    }
}

