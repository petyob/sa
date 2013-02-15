using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.GCD
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("a= ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.Write("b= ");
                int b = Convert.ToInt32(Console.ReadLine());


                if (a < b)
                { // exchange
                    a = a + b;
                    b = a - b;
                    a = a - b;
                }

                
                while (b > 0)                         
                {
                    int remainder = a % b;

                    a = b;

                    b = remainder;            
                }

                Console.WriteLine("the greatest common divisor: "+ a);
            
            }
  



        }
    }
}
