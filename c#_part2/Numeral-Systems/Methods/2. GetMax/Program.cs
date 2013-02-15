using System;

class Program
// method GetMax() with two parameters that returns the bigger of two integers. 
// Write a program that reads 3 integers from the console 
// and prints the biggest of them using the method GetMax().
{
    static void Main()
    {
        int[] arr = new int[3];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = ReadNumber();
        }

        int max = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            max = GetMax(max, arr[i]);
        }
        Console.WriteLine("max = " + max);

    }

    private static int ReadNumber()
    {
        Console.Write("Enter a number: ");
        return int.Parse(Console.ReadLine());
    }

    static int GetMax(int a, int b)
    {
        return Math.Max(a, b);
    }

}

