using System;

namespace _7.Greatest_of_given_5
{
    class Program
    {
        // program that finds the greatest of given 5 variables.
        static void Main(string[] args)
        {
            int a = 1,
                b = 14,
                c = 2,
                d = 7,
                e = 1;

            int bigest = a;

            if (bigest < b)
            {
                bigest = b;
            }

            if (bigest < c)
            {
                bigest = c;
            }

            if (bigest < d)
            {
                bigest = d;
            }

            if (bigest < e)
            {
                bigest = e;
            }

            Console.WriteLine(bigest);


        }
    }
}
