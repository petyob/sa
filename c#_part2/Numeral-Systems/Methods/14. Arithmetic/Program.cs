using System;
//using System.Collections.Generic;

class Program
// Write methods to calculate minimum, maximum, 
//average, sum and product of given set of integer numbers.
//Use variable number of arguments
{
    static void Main()
    {
        //List<int> items = new List<int>() { 1, 2, 3 };

        Console.WriteLine("Sum = " + Sum(1, 2, 3, 4));
        Console.WriteLine("Sum = " + Sum());
        Console.WriteLine("Sum = " + Sum(4));

        Console.WriteLine("Product = " + Product(-1, 2, 3, 4));
        Console.WriteLine("Product = " + Product());
        Console.WriteLine("Product = " + Product(10));

        Console.WriteLine("Average = " + Average(4, 2, 3, 4));
        Console.WriteLine("Average = " + Average());
        Console.WriteLine("Average = " + Average(3));

        Console.WriteLine("Min = " + Min(4, 2, 3, 4));
        Console.WriteLine("Min = " + Min());

        Console.WriteLine("Max = " + Max(4, 2, 3, 4));

    }

    private static int Sum(params int[] items)
    {
        int sum = 0;
        foreach (var item in items)
        {
            sum += item;
        }
        return sum;
    }

    private static int Min(params int[] items)
    {
        int min = int.MaxValue;
        foreach (var item in items)
        {
            if (min > item)
            {
                min = item;
            }
        }
        return min;
    }

    private static int Max(params int[] items)
    {
        int max = int.MinValue;
        foreach (var item in items)
        {
            if (max < item)
            {
                max = item;
            }
        }
        return max;
    }

    private static int Product(params int[] items)
    {
        int product = 1;
        foreach (var item in items)
        {
            product *= item;
        }
        return product;
    }

    private static int Average(params int[] items)
    {
        int average = int.MinValue;
        if (items.Length != 0)
        {
            average = Sum (items) / items.Length;
        }
        return average;

    }

}

