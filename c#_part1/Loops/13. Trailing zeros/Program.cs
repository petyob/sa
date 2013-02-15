using System;
using System.Numerics;

namespace _13.Trailing_zeros
{
    class Program
    {
        // program that calculates for given N how many trailing zeros present at the end of the number N!
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("n= ");
                uint n = Convert.ToUInt32(Console.ReadLine());

                // For testing
                //BigInteger fac = 1;

                //for (int i = 2; i < n + 1; i++)
                //{
                //    fac = fac * i;
                //}

                //Console.WriteLine(fac);
                
                int trailingZero = 0;
                int endSum = (int) Math.Floor(Math.Log( n, 5));

                for (int i = 1; i <= endSum; i++)
                {
                    trailingZero += (int)(n / Math.Pow(5,i));
                    
                }
                Console.WriteLine( trailingZero );
                
            }

        }
    }
}
