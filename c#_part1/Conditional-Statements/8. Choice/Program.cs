using System;

namespace _8.Choice
{
    // Program that, depending on the user's choice inputs int, double or string variable.
    // If the variable is integer or double, increases it with 1. 
    // If the variable is string, appends "*" at its end. 
    // The program must show the value of that variable as a console output. Use switch statement.

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Make your choice for inputs(0, 1 or 2): 
0. - int
1. - double
2. - string");

            string choice = Console.ReadLine();

            string input = Console.ReadLine();

            switch ( choice )
            {
                case "0": Console.WriteLine(Convert.ToInt32(input) + 1) ; break;

                case "1": Console.WriteLine(Convert.ToDouble(input) + 1); break;

                case "2": Console.WriteLine(input + "*"); break;

                default : Console.WriteLine("Invalid choice"); break;


            }
        }
    }
}
