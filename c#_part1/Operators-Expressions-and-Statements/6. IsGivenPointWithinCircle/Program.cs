using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.IsGivenPointWithinCircle
{
    //Write an expression that checks if given point (x,  y) is within a circle K(O, 5)
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;

            Console.WriteLine("X coordinate: ");

            bool isNumber = double.TryParse(Console.ReadLine(), out x);

            if (! isNumber)
            {
                Console.WriteLine("Number requared!");
                               
            }
            Console.WriteLine("Y coordinate: ");

            isNumber = double.TryParse(Console.ReadLine(), out y);

            if (!isNumber)
            {
                Console.WriteLine("Number requared!");

            }

            double d = Math.Sqrt(x * x + y * y);

            if (d > 5)
            {
                Console.WriteLine("Out");
            }
            else
            
            {
                Console.WriteLine("In");
            }



        }
    }
}

