using System;

namespace _3.Calculate_rectangle
{
    // Expression that calculates rectangle’s area by given width and height.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter width: ");

            double width = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter height: ");

            double height = Convert.ToDouble(Console.ReadLine());

            double area = width * height;

            Console.WriteLine("Area : {0}", area);
 
        }
    }
}
