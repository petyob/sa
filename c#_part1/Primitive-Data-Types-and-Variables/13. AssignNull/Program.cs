using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.AssignNull
{
    //Create a program that assigns null values to an integer and to double variables. Try to print them on the console, try to add some values or the null literal to them and see the result.

    class Program
    {
        static void Main(string[] args)
        {
            int? first = null;
	        double? second = null;
	        Console.WriteLine("First: {0} ,Second: {1}", first, second);
            Console.WriteLine("First: {0} ,Second: {1}", first.GetValueOrDefault(), second.GetValueOrDefault());
        }
    }
}
