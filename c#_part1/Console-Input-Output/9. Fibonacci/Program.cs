using System;

namespace _9.Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a = 0, b = 1, c;

            Console.WriteLine(a);
            Console.WriteLine(b);

            for (int i = 0; i < 99; i++)
            {
                checked
                { 
                 c = a + b; 
                }

                a = b;
                b = c;

                Console.WriteLine(b);
            }
        }
    }
}
