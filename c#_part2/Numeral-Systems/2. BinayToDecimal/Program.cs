using System;

class Program
//Write a program to convert binary numbers to their decimal representation.
{
    static void Main()
    {
        while (true)
        {
            string number = Console.ReadLine();
            Console.WriteLine(Convert.ToInt64(number,2));
            
            // Seconf method
            long n = BinToDec(number);

            Console.WriteLine(n);
        }


    }

    static int GetBit(string s, int position)
    {
        return s[position] - '0';
    }

    static long BinToDec(string binary)
    {
        long n = 0;
        int power = 1;
        
        for (int i = binary.Length - 1; i >= 0; i--)
        {
            
            n = n + power * GetBit(binary, i);
            power = power*2;
        }
        
        return n;
    }

}

