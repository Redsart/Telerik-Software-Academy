//Problem 5. Hexadecimal to binary

//Write a program to convert hexadecimal numbers to binary numbers (directly).
//Problem 5. Hexadecimal to binary

//Write a program to convert hexadecimal numbers to binary numbers (directly).

using System;

class HexadecimalToBinary
{
    static void Main()
    {
        Console.Write("Please enter Hexadecimal number: "); //1F4
        string hex = Console.ReadLine();
        char[] array = hex.ToCharArray();
        string res = "";
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (char.IsDigit(array[i]))
            {
                switch (array[i])
                {
                    case '1': res = "0001" + res; break;
                    case '2': res = "0010" + res; break;
                    case '3': res = "0011" + res; break;
                    case '4': res = "0100" + res; break;
                    case '5': res = "0101" + res; break;
                    case '6': res = "0110" + res; break;
                    case '7': res = "0111" + res; break;
                    case '8': res = "1000" + res; break;
                    case '9': res = "1001" + res; break;
                    default:
                    case '0': res = "0000" + res; break;
                }
            }
            else
            {
                switch (array[i])
                {
                    case 'A': res = "1010" + res; break;
                    case 'B': res = "1011" + res; break;
                    case 'C': res = "0011" + res; break;
                    case 'D': res = "1100" + res; break;
                    case 'E': res = "1101" + res; break;
                    case 'F': res = "1111" + res; break;
                    default:
                        break;
                }
            }
        }
        Console.WriteLine("In Binary: {0}", res);
    }
}

