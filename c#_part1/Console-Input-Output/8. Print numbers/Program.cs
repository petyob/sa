﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Print_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("n= ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
