using System;
using System.Numerics;


class Program
//Write a program to calculate n! for each n in the range [1..100]. 
//Hint: Implement first a method that multiplies a number 
//represented as array of digits by given integer number. 
{
    
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        
        Console.WriteLine(Factorial(n));
    }

    class BigNumbers
    {
        //public List<byte> digit;
        //= { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        //public static digit [] multiply (digit[] arr, int n)
        //{
        //    return arr;        
        //}
    }

    private static BigInteger Factorial(int n)
    {
        BigInteger factorial = 1;

        for (int i = 1; i < n + 1; i++)
        {
            factorial = factorial * i;
        }
        return factorial;
    }
}

