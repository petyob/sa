using System;

namespace _6.Expresion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x= ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("n= ");
            int n = Convert.ToInt32(Console.ReadLine());

            double sum = 1,
                factorial = 1,
                power = 1;

            for (int i = 1; i < n; i++)
            {
                factorial = factorial * i;
                power = power * x;

                sum = sum + factorial / power;
            }

            Console.WriteLine(sum);
           

        }
    }
}
