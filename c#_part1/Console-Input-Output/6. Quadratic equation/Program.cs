using System;

namespace _6.Quadratic_equation
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            while (true)
            {
                Console.Write("a = ");
                a = Convert.ToDouble(Console.ReadLine());

                Console.Write("b = ");
                b = Convert.ToDouble(Console.ReadLine());

                Console.Write("c = ");
                c = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("{0}x^2+{1}x+{2}=0",a,b,c);
                if (a == 0)
                {
                    if (b == 0)
                    {
                        if (c == 0)
                        {
                            Console.WriteLine("Every real number is a root!");
                        }
                        else
                        {
                            Console.WriteLine("There are no possible roots of this equation!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("1 root - x= {0}", c / b);
                    }
                }
                else
                {
                    double d = b * b - 4 * a * c;
                    if (d < 0)
                    {
                        Console.WriteLine("The eqauation has no real roots!");
                    }
                    else if (d == 0)
                    {
                        Console.WriteLine("x = {0}", (-b) / (2 * a));
                    }
                    else
                    {
                        double sqrtD = Math.Sqrt(d); 
                        Console.WriteLine("x1 = {0}\nx2 = {1}",
                            (-b - sqrtD) / (2 * a), (-b + sqrtD) / (2 * a));
                    }
                }
            }

        }
    }
}
