using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 2000;
            for (int i = 0; i < n; i++)
            {
                if (!((i % 21) == 0))
                {
                    Console.WriteLine(i);
                }
                
            }
        }
    }
}
