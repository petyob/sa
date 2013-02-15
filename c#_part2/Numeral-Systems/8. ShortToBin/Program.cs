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
            Console.WriteLine(Convert.ToString(Convert.ToInt16(number), 2));

            // 2 method. 

            Console.WriteLine(ShortToBin(number));
        }
    }

    private static string ShortToBin(string decNumber)
    {
        StringBuilder result = new StringBuilder();
        int n = short.Parse(decNumber);
        bool isNegative = false;
        if (n < 0 )
        {
            n = n + 32768;  // Binary representation is : n =-(2^15) + x => x = n +32768
            isNegative = true;
        }
        while (n > 0)
        {
            byte bit = (byte)(n % 2);
            n =  n / 2;

            result.Insert(0, bit);
        }

        if (isNegative)
        {
            result.Insert(0, 1);
        }
        return result.ToString();
    }
}

