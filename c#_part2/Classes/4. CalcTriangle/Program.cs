using System;

class Program
//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.
{
    class triangle
    {
        public static double Surface(double a, double b, double c)
        {
            double s, p;

            p = (a + b + c) / 2;
            s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            return s;
        }

        public static double Surface(double a, double ha)
        {
            double s;

            s = a * ha;

            return s;
        }

        public static double Surface(double a, double b, decimal angle)
        {
            double s;
            double ang = (double) angle / 360;

            s = a * b * Math.Sin(ang);

            return s;
        }

    }

    static void Main()
    {

        Console.WriteLine(triangle.Surface(3, 4, 5d));
        Console.WriteLine(triangle.Surface(3, 4, 100m));
        Console.WriteLine(triangle.Surface(3, 4));
      

    }
}

