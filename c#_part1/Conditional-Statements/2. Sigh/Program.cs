using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Sigh
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            byte countNegative = 0;

            if ( !( a == 0 ) && !( b == 0 ) && !( c == 0 ) )
            {             

                if ( a < 0 )
                {
                    countNegative++;
                }

                if ( b < 0 )
                {
                    countNegative++;
                }

                if ( c < 0 )
                {
                    countNegative++;
                }            
            }

            char sign = ( countNegative % 2 == 0 ) ? '+' : '-';
           
            Console.WriteLine(sign);



        }
    }
}
