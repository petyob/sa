using System;

namespace _2.Division
{
    // boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

    class Program
    {
        static void Main(string[] args)
        {
            int number;
            bool isNumber = int.TryParse(Console.ReadLine(), out number);

            if (isNumber)
            {
                if ((number % 5 == 0) && ( number % 7 == 0))
                {
                    Console.WriteLine("The number can be devided by 5 and 7");
                }
                else
                {
                    Console.WriteLine("The number can NOT be devided by 5 and 7");
                }

            }
            else
            {
                Console.WriteLine("Integer number requared!");
            }
        }
    }
}
