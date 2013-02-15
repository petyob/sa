using System;

namespace Compares
{
               
   class Program
    //Write a program that safely compares floating-point numbers with precision of 0.000001. Examples:(5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003)  true

   {
        static void Main(string[] args)
        {
            double  a = 5.0000001d;
            double  b = 5.00000003d;

            Console.WriteLine("A = {0} , B = {1}", a ,b );

            decimal aRound = Math.Round( (decimal)a , 6); 
            decimal bRound = Math.Round( (decimal)b , 6);

            Console.WriteLine("A is equal to B - {0}", (a == b));
            Console.WriteLine("A is equal to B with precision 0.000001 - {0}", (aRound == bRound));


     
        }
    }
}
