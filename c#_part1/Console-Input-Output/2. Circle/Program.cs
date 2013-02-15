using System;

namespace _2.Circle
{
    class Program
    {
        //reads the radius r of a circle and prints its perimeter and area.
        static void Main(string[] args)
        {
            int r;
            double pi = Math.PI;

            Console.Write("r = ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out r))
            {
                Console.WriteLine("P = " + (2* pi * r));
                Console.WriteLine("S = " + (pi * r * r));
            }

        }
    }
}
