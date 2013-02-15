using System;

namespace _7.Sum_N_numbers
{
    // program that gets a number n and after that gets more n numbers and calculates and prints their sum. 

    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("n= ");
            n = Convert.ToInt32(Console.ReadLine());
            
            double sum = 0, aNumber;

            for (int i = 1; i <= n; i++)
            {
                Console.Write("number {0} = ", i);

                aNumber = Convert.ToDouble(Console.ReadLine());

                sum += aNumber;
            }

            Console.WriteLine("sum = {0}", sum);
        }
    }
}
