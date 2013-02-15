using System;
using System.Text;

namespace _12.PrintAccii
{
    // prints the entire ASCII table of characters on the console.
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("ACCII table:");
            
            for (int i = 1; i < 128; i++)
            {
                Console.WriteLine("{0} - {1}", i, (char)i); 
            }
            
            Console.WriteLine("Extended ACCII table:");

            for (int i = 128; i < 256; i++)
            {
                Console.WriteLine("{0} - {1}", i, (char)i); 
            }



        }
    }
}
