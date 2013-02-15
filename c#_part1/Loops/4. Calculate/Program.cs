using System;

namespace _4.Calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("k= ");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.Write("n= ");
            int n = Convert.ToInt32(Console.ReadLine());

            long fac = 1;

            for (int i = k; i < n; i++)
            {
                fac *= i;
            }
            Console.WriteLine("n!/k! = " + fac);
        }
    }
}
