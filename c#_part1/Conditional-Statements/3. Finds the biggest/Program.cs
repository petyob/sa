using System;

namespace _3.Finds_the_biggest
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            
            int bigest = a;

            if (bigest >= b)
            {
                if (bigest < c)
                {
                    bigest = c;
                }
            }
            else
            {
                bigest = b;
                if (bigest < c)
                {
                    bigest = c;
                }
            }                   

            Console.WriteLine(bigest);

        }
    }
}
