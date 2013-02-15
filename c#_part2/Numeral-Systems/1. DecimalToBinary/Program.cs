using System;
using System.Text;

class Program
//Write a program to convert decimal numbers to their binary representation.
{
    static void Main()
    {
        while (true)
        {
            string number = Console.ReadLine();
            Console.WriteLine(Convert.ToString(Convert.ToInt64(number), 2));

            // 2 method. 

            Console.WriteLine(DecToBin(number));
        }
    }

    private static string DecToBin(string decNumber)
    {
        StringBuilder result = new StringBuilder();
        ulong n = ulong.Parse(decNumber);

        while (n > 0)
        {
            byte bit = (byte)(n & 1); //Get last bit
            result.Insert(0, bit);

            n = n >> 1; //shift all bits

        }

        return result.ToString();
    }
}

