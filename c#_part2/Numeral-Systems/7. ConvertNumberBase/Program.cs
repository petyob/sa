using System;
using System.Text;

class Program
//Write a program to convert from any numeral system of given base s 
//to any other numeral system of base d (2 ≤ s, d ≤  16).
{
    static void Main()
    {
        while (true)
        {
            Console.Write("s = ");
            int s = int.Parse(Console.ReadLine());

            Console.Write("d = ");
            int d = int.Parse(Console.ReadLine());

            string number = Console.ReadLine();

            string dec = BaseXtoDec(number, baseX: s);
            Console.WriteLine("(10) = " + dec);

            string numberBaseD = DecToBaseX(dec, baseX: d);
            Console.WriteLine("({0}) = {1}", d, numberBaseD);

        }
    }
    static int GetDigit(string s, int position)
    {
        char digit = s[position];

        if ((digit >= '0') && (digit <= '9'))
        {
            return s[position] - '0';
        }
        else if ((digit >= 'a') && (digit <= 'f'))
        {
            return s[position] - 'a' + 10;
        }
        else
        {
            return -1; //Error
        }
    }

    static string BaseXtoDec(string number, int baseX)
    {
        long n = 0;
        int power = 0;

        number = number.ToLower(); // To lower case

        for (int i = number.Length - 1; i >= 0; i--)
        {
            int dig = GetDigit(number, i);

            if (dig < baseX)
            {
                n = n + ((long)Math.Pow(baseX, power) * (long)GetDigit(number, i));
                power++;
            }
            else
            {
                throw new ArgumentException("Invalid digit for base " + baseX);
            }

        }

        return n.ToString();
    }

    static string DecToBaseX(string decNumber, int baseX)
    {
        StringBuilder binNumber = new StringBuilder();
        ulong n = ulong.Parse(decNumber);  // Bigger type to be able to work with bigger numbers

        while (n > 0)
        {
            char digit;

            ulong remainder = n % (ulong)baseX;

            if (remainder > 9)
            {
                digit = (char)('a' + remainder - 10);
            }
            else
            {
                digit = (char)('0' + remainder);
            }

            n = n / (ulong)baseX;

            binNumber.Insert(0, digit);
        }

        return binNumber.ToString();

    }

}




