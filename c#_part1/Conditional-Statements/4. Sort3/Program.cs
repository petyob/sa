using System;

namespace _4.Sort3
{
    class Program
    {
        // Sort 3 real values in descending order using nested if statements.

        static void Main(string[] args)
        {
            double a = 11;
            double b = 3;
            double c = 6;

            if (a < b)
            {  // Swap the values
                a = a + b;
                b = a - b;
                a = a - b;

                if (b < c)
                {
                    b = b + c;
                    c = b - c;
                    b = b - c;

                    if (a < b)
                    {
                        a = a + b;
                        b = a - b;
                        a = a - b;
                    }
                }
            }
            else
            {
                if (b < c)
                {
                    b = b + c;
                    c = b - c;
                    b = b - c;

                    if (a < b)
                    {
                        a = a + b;
                        b = a - b;
                        a = a - b;
                    }
                }
            }


            Console.WriteLine(a + ", " + b +", " + c);
        }
    }
}
