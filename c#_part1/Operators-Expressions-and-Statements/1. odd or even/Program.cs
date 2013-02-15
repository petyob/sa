using System;

namespace _1.odd_or_even
{
    // Write an expression that checks if given integer is odd or even.

    class Program
    {
        static void Main(string[] args)
        {
            int number;
            string result;
            bool isNumber = int.TryParse(Console.ReadLine(), out number);

            if (isNumber)
            {
                if (number % 2 == 1)
                {
                    result = "Even";
                }
                else
                {
                    result = "Odd";
                }

                Console.WriteLine("The number is {0}", result);
            }
            else
            {
                Console.WriteLine("Integer number requared!");
            }
                      
            
        }
    }
}
