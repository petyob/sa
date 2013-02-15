using System;

namespace _1.Exchange
{
    // Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.

    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                a = a + b;
                b = a - b;
                a = a - b;
            
            }
            Console.WriteLine(a+", "+b);
        }
    }
}
