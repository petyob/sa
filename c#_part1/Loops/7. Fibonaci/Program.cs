using System;
using System.Numerics;


namespace _7.Fibonaci
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger a = 0, b = 1, c;

            Console.Write("n= ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(a);
            Console.WriteLine(b);

            for (int i = 0; i < n; i++)
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
