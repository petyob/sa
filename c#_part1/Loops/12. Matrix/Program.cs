using System;

namespace _12.Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n;
            do
            {
                Console.Write("n(<20) = ");
                n = Convert.ToUInt32(Console.ReadLine());
            } while (n > 19);

            for (int i = 1; i < n+1 ; i++)
            {
                for (int k = i; k < n+i; k++)
                {
                    Console.Write("{0,3}",k);
                }

                Console.WriteLine();
            }

        }
    }
}
