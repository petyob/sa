using System;

namespace _8.CalculatesTrapezoidArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\"a\"= ");

            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("\"b\"= ");

            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("\"h\"= ");

            double h = Convert.ToDouble(Console.ReadLine());

            double area = (a + b) * h / 2;

            Console.WriteLine("Area = {0}", area);
        }
    }
}
