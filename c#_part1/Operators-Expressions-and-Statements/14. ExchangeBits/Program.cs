using System;

namespace _14.ExchangeBits
{
    // Write a program that exchanges bits {p, p+1, …, p+k-1) with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer.

    class Program
    {
        static void Main(string[] args)
        {
            int number;
            byte p, q, k;
            while (true)
            {

                Console.WriteLine("Number:");

                bool isNumber1 = int.TryParse(Console.ReadLine(), out number);

                Console.Write("p= ");
                p = Convert.ToByte(Console.ReadLine());
                Console.Write("q= ");
                q = Convert.ToByte(Console.ReadLine());
                Console.Write("k= ");
                k = Convert.ToByte(Console.ReadLine());

                Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

                int mask = ((number >> p) ^ (number >> q)) & ((1 << k) - 1);

                number = number ^ ((mask << p) | (mask << q));

                Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
            }
        }
    }
}
