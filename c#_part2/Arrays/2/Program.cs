using System;

class Program
// Reads two arrays from the console and compares them element by element.
{
    static void Main()
    {
        Console.WriteLine("Enter the array's length:");
        int n = int.Parse(Console.ReadLine());

        int[] arr1 = new int[n];
        int[] arr2 = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("arr1[{0}] = ", i);
            arr1[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            Console.Write("arr2[{0}] = ", i);
            arr2[i] = int.Parse(Console.ReadLine());
        }

        bool isEqual = true;  // Mark arrays as equal until we find any difference.

        for (int i = 0; i < n; i++)
        {
            if (arr1[i] != arr2[i])
            {
                isEqual = false;
                break;
            }

        }

        Console.WriteLine("Arrays are {0} equal.", (isEqual? "":"NOT"));

    }
}

