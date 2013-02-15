using System;

namespace _13.Exchanges_bits
{
    // exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                uint number;

                Console.WriteLine("Number:");

                bool isNumber1 = uint.TryParse(Console.ReadLine(), out number);

                Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

                uint mask = ((number >> 3) ^ (number >> 24)) & ((1 << 3) - 1);

                number = number ^ ((mask << 3) | (mask << 24));

                Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
            }


        }
    }
}
