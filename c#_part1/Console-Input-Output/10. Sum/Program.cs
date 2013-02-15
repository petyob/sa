using System;

namespace _10.Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 1, add, oldsum;
            int i = 1;
 
            do
            {
                oldsum = sum;

                add = Math.Pow(-1, i) / (i + 2);

                sum = sum + add;

                i++;

                Console.WriteLine(i + " - " + sum);

            } while (Math.Abs(sum - oldsum) > 0.00029);

            
        }

    }
}


