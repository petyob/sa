using System;

namespace _12.SetBit
{
    // We are given integer number n, value v (v=0 or 1) and a position p. Write a sequence of operators that modifies n to hold the value v at the position p from the binary representation of n.
	// Example: n = 5 (00000101), p=3, v=1  13 (00001101)
	// n = 5 (00000101), p=2, v=0  1 (00000001)

    class Program
    {
        static void Main(string[] args)
        {
            int number, position, bit, result;
            Console.Write("Number: ");
            bool isNumber1 = int.TryParse(Console.ReadLine(), out number);
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

            Console.Write("0 or 1: ");
            bool isNumber3 = int.TryParse(Console.ReadLine(), out bit);

            
            while (true)
            {
                Console.Write("Position: ");
                bool isNumber2 = int.TryParse(Console.ReadLine(), out position);

                if (isNumber1 && isNumber2)
                {
                    if (bit == 1)
                    {
                        int mask = 1 << position;

                        result = number | mask;
                    }
                    else
                    {
                        int mask = ~(1 << position);

                        result = number & mask; 
                    }
                    
                    Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));

                }
                else
                {
                    Console.WriteLine("Integer numbers requared!");
                }
            }

        }
    }
}
