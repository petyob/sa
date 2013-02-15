using System;
using System.Text;

class Program
//Write a program to convert decimal numbers to their hexadecimal representation.
{
    static void Main()
    {
        while (true)
        {
            string number = Console.ReadLine();
            Console.WriteLine(Convert.ToString(Convert.ToInt64(number), 16));

            // 2 Method
            Console.WriteLine(DecToHex(number));
            
        }      
    }

    static string DecToHex(string decNumber)
    {
        StringBuilder binNumber = new StringBuilder();
        ulong n = ulong.Parse(decNumber);

        while (n > 0)
        {
            char digit;

            byte remainder = (byte)(n & 15);  //=n % 16;

            if (remainder > 9)
            {
                digit = (char)('a' + remainder -10);
            }
            else
            {
                digit = (char)('0' + remainder );
            }

            n = n >> 4;  //n = n / 16;

            binNumber.Insert(0,digit);
        }

        return binNumber.ToString();

    }
}

