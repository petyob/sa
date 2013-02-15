using System;

namespace _4.Division_by_5
{
    class Program
    {
        static void Main(string[] args)
        {
            uint a, b;
            bool isNumber;

            Console.Write("a = ");
            string input = Console.ReadLine();

            isNumber = uint.TryParse(input, out a);

            Console.Write("b = ");
            input = Console.ReadLine();

            isNumber = uint.TryParse(input, out b) && isNumber;

            if (!isNumber)
            {
                Console.WriteLine("Not integer!");
            }
            else
            {
                int count = 0;

                uint c = a;
                a = Math.Min(a, b);
                b = Math.Max(a, c);
                //if (a > b)
                //{
                //    uint c = a; 
                //    a = b;
                //    b = c;
                //}
                
                for (uint i = a; i < b; i++)
                {
                    if ((i % 5) == 0)
                        count++;
                }
                Console.WriteLine(count);
            }
        }
    }
}
