using System;


namespace _11.BitExtract
{
    // expression that extracts from a given integer i the value of a given bit number b. Example: i=5; b=2  value=1.

    class Program
    {
        static void Main(string[] args)
        {
            int number, position;
            bool isNumber1 = int.TryParse(Console.ReadLine(), out number);

            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

            while (true)
            {
                bool isNumber2 = int.TryParse(Console.ReadLine(), out position);

                if (isNumber1 && isNumber2)
                {
                    int mask = 1 << position;

                    int result = number & mask;
                        result = result >> position;
                    
                    Console.WriteLine(result);

                }
                else
                {
                    Console.WriteLine("Integer numbers requared!");
                }
            }
        }
    }
}
