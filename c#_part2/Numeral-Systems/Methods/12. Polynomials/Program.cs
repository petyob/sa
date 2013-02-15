using System;

class Program
//Extend the program to support also subtraction and multiplication of polynomials.

{
    static void Main()
    {
        int[] a = { 11, 0, 5, 6 };
        int[] b = { 5, 7 };

        int[] subtraction = Polynomials.Subtraction(a, b);
        Polynomials.Print(subtraction);

        int[] multiplication = Polynomials.Multiplication(a, b);
        Polynomials.Print(multiplication);

    }

    class Polynomials
    {
        public static int[] Multiplication(int[] a, int[] b)
        {

            int[] product  = new int[a.Length + b.Length];

            return product;
        }

        public static int[] Subtraction(int[] a, int[] b)
        {
            int length = Math.Max(a.Length, b.Length);
            int[] subtraction = new int[length];

            for (int i = 0; i < a.Length; i++)
            {
                subtraction[i] = a[i];
            }

            for (int i = 0; i < b.Length; i++)
            {
                subtraction[i] = subtraction[i] - b[i];
            }

            return subtraction;
        }

        public static int[] Sum(int[] a, int[] b)
        {
            int length = Math.Max(a.Length, b.Length);
            int[] sum = new int[length];

            for (int i = 0; i < a.Length; i++)
            {
                sum[i] = a[i];
            }

            for (int i = 0; i < b.Length; i++)
            {
                sum[i] = sum[i] + b[i];
            }

            return sum;
        }

        public static void Print(int[] p)
        {

            for (int i = 0; i < p.Length; i++)
            {
                Console.Write(p[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

