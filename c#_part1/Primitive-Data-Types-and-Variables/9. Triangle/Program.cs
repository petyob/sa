using System;
using System.Text;

namespace _9.Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;
            char copyright = '\u00A9';
            Console.WriteLine("  {0}  \n {0}{0}{0} \n{0}{0}{0}{0}{0}", copyright);
        }
    }
}
