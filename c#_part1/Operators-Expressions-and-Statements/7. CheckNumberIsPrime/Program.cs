using System;

namespace _7.CheckNumberIsPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            while (true)
            {
                Console.Write("Number: ");
                int.TryParse(Console.ReadLine(), out n);
                if (n > 100)
                {
                    Console.WriteLine("use number < 100");
                    continue;
                }

                double maxDiv =  Math.Sqrt(n)+1;
                bool isPrime = true;
                for (int i = 2; i < maxDiv; i++)
                {
                    if ((n % i) == 0)
                    {
                        isPrime = false;
                        continue;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine("Prime");
                }
                else
                {
                    Console.WriteLine("Not prime");
 
                }
            }


        }
    }
}
