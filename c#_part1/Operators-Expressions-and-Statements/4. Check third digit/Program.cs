using System;

//  expression that checks for given integer if its third digit (right-to-left) is 7
    class Program
    {
        static void Main(string[] args)
        {
            long number;
            bool isNumber = long.TryParse(Console.ReadLine(), out number);

            if (isNumber)
            {
                long divBy100 = number / 100;
                long digit = divBy100 % 10;
                if (digit == 7)
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
                Console.WriteLine("Integer number requared!");
            }
        }
    }

