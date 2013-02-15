using System;

class Program
//Write a program to convert hexadecimal numbers to their decimal representation.
{
    static void Main()
    {
        while (true)
        {
            string hexNumber = Console.ReadLine();
            Console.WriteLine(Convert.ToInt64(hexNumber, 16));

            // Second method
            long decNumber = HexToDec(hexNumber);

            Console.WriteLine(decNumber);
        }
   
    }

    static int GetDigit(string s, int position)
    {
        char digit = s[position];

  
        if ((digit >= '0') && (digit <= '9'))
        {
            return s[position] - '0';
        }
        else if ((digit >= 'A') && (digit <= 'F'))
        {
            return s[position] - 'A' + 10;
        }
        else
        {
            return -1; //Error
        }
    }

    static long HexToDec(string hex)
    {
        long n = 0;
        int power = 0;

        hex = hex.ToUpper(); // To upper case

        for (int i = hex.Length - 1; i >= 0; i--)
        {

            n = n + ((long)Math.Pow(16, power) * GetDigit(hex, i));
            power++;
        }

        return n;
    }
}

