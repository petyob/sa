using System;

namespace _8.Declare
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = @"The ""use"" of quatations causes difficulties.";
            string str2 = "The \"use\" of quatations causes difficulties.";
            Console.WriteLine(str1);
            Console.WriteLine(str2);
        }
    }
}
