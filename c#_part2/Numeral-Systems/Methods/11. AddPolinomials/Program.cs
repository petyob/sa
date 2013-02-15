using System;

class Program
//Write a method that adds two polynomials. 
//Represent them as arrays of their coefficients as in the example below:
// x2 + 5 = 1x2 + 0x + 5  5 0 1
{
    static void Main()
    {
        int[] a = { 11, 0, 5, 6 }; 
        int[] b = { 5, 7 };

        int[] sum = Polynomials.Sum(a, b);
        Polynomials.Print(sum);
    }

    class Polynomials
    {
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
                sum[i] = sum[i]+ b[i];
            }

            return sum;
        }

        public static void Print(int[] p)
        {

            for (int i = 0; i < p.Length; i++)
            {
                Console.Write(p[i] + " ");
            }
        }
    }
}

