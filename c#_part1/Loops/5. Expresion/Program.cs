using System;
using System.Numerics;

namespace _5.Expresion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("k= ");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.Write("n= ");
            int n = Convert.ToInt32(Console.ReadLine());

            BigInteger  a = factorial(n),
                        b = factorial(k),
                        c = factorial(k - n);

            Console.WriteLine("(n!*k!)/(k-n)!= " + a*b/c);
        }

        static BigInteger factorial(int n)
        {
            BigInteger fac = 1;
            for (int i = n; i > 0; i--)
            {
                fac = fac*i;
            }
            return fac;
        }

    }
}
