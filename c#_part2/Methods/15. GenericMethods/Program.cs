using System;
using System.Collections.Generic;

class Program
//Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.).
//Use generic method (read in Internet about generic methods in C#).
{
    
    static void Main()
    {
        List<int> items = new List<int>() {0};

        Console.WriteLine("Sum = " + Sum(1, 2.5 , 3, 4));
        Console.WriteLine("Sum = " + Sum(5));
        Console.WriteLine("Sum = " + Sum("sfdqsdfq","aaaaaaaaa"));

        Console.WriteLine("Product = " + Product(-1, 2.9 , 3));
        //Console.WriteLine("Product = " + Product());
        Console.WriteLine("Product = " + Product(10));

        Console.WriteLine("Average = " + Average(4, 2, 3, 4));
        Console.WriteLine("Average = " + Average(3));

        Console.WriteLine("Min = " + Min(4, 2, 3, 4));
        Console.WriteLine("Min = " + Min("dsfs","das"));

        Console.WriteLine("Max = " + Max(4, 2, 3, 4));
        Console.WriteLine("Max = " + Max("ffqewf","xxx","sfawf"));

        
    }

    private static T Sum<T>(params T[] items)
    {
        dynamic sum = default(T);

        foreach (T item in items)
        {
            sum = sum + item;
        }

        return sum;
    }


    private static T Min<T>(params T[] items) where T : IComparable<T>
    {
        dynamic min = items[0];

        foreach (var item in items)
        {
            if (item.CompareTo(min) > 0)
            {
                min = item;
            }
            
        }
        return min;
    }

    private static T Max<T>(params T[] items) where T : IComparable<T>
    {
        dynamic max = items[0];

        foreach (var item in items)
        {
            if (item.CompareTo(max) > 0)
            {
                max = item;
            }

        }
        return max;
    }

    private static T Product<T>(params T[] items)
    {
        dynamic product = 1;
        foreach (var item in items)
        {
            product *= item;
        }
        return product;
    }

    private static T Average<T>(params T[] items)
    {
        dynamic average;

        average = (Sum(items) / ((dynamic)items.Length));
        
        return average;

    }

}

