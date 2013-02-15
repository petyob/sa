using System;

namespace _5.GreaterNumber
{
    // gets two numbers from the console and prints the greater of them. Don’t use if statements.
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            bool isNumber;
            
            Console.Write("a = ");
            string input = Console.ReadLine();

            isNumber = int.TryParse(input, out a);

            Console.Write("b = ");
            input = Console.ReadLine();

            isNumber = int.TryParse(input, out b) && isNumber;

            if (!isNumber)
            {
                Console.WriteLine("Not Numbers!");
            }
            else
            {
                Console.WriteLine("Max= " +
                    Math.Max(a, b));
            }
        }
    }
}
