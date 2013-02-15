using System;
using System.Collections.Generic;
using System.Text;

class Program
//Write a program to convert binary numbers to hexadecimal numbers (directly).
{
    static void Main()
    {
        while (true)
        {
            string binNumber = Console.ReadLine();
            Console.WriteLine(Convert.ToString(Convert.ToInt64(binNumber, 2), 16));

            //Second Method
            string hexNumber = BinToHex(binNumber);

            Console.WriteLine(hexNumber);
        }

    }

    private static string BinToHex(string binNumber)
    {
        Dictionary<string, string> binHex = new Dictionary<string, string>()
            {
                {"0000", "0"},
                {"0001", "1"},
                {"0010", "2"},
                {"0011", "3"},
                {"0100", "4"},
                {"0101", "5"},
                {"0110", "6"},
                {"0111", "7"},
                {"1000", "8"},
                {"1001", "9"},
                {"1010", "a"},
                {"1011", "b"},
                {"1100", "c"},
                {"1101", "d"},
                {"1110", "e"},
                {"1111", "f"},
            };

        StringBuilder hex = new StringBuilder();

        int length = binNumber.Length;

        int divTo4 = length % 4;
        if (divTo4 > 0)
        {
            string zeros = new string('0', 4 - divTo4);
            binNumber = zeros + binNumber;
        }

        for (int i = 0; i < length; i += 4)
        {
            string digitInHex;
            bool isValid = binHex.TryGetValue(binNumber.Substring(i, 4), out digitInHex);
            if (!isValid)
            {
                throw new ArgumentException("Invalid input for binary number!");
            }
            hex.Append(digitInHex);
        }

        return hex.ToString().TrimStart('0');
    }
}

