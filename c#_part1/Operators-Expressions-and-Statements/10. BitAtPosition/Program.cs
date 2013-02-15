using System;


namespace _10.BitAtPosition
{
    class Program
    {
        // boolean expression that returns if the bit at position p (counting from 0) in a given integer number v has value of 1. Example: v=5; p=1  false.

        static void Main(string[] args)
        {
            int number, position;
            bool isNumber1 = int.TryParse(Console.ReadLine(), out number);

            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

            //while (true)
            //{
                bool isNumber2 = int.TryParse(Console.ReadLine(), out position);

                if (isNumber1 && isNumber2)
                {
                    int mask = 1 << position;

                    if ((number & mask) > 0)
                    {
                        Console.WriteLine("true");
                    }
                    else
                    {
                        Console.WriteLine("false");
                    }
                }
                else
                {
                    Console.WriteLine("Integer numbers requared!");
                }
            //}

        }
    }
}
