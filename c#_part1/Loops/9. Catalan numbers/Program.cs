using System;
using System.Numerics;


namespace _9.Catalan_numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("n= ");
            int n = Convert.ToInt32(Console.ReadLine());

            BigInteger  c =  factorial(2*n) / factorial(n+1) / factorial(n);

            Console.WriteLine("Catalan -(2n!)/(n+1)!/(n!)= " + c);

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

