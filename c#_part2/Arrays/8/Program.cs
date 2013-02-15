using System;

class Program
{
    static void Main()
    {
        //Write a program that finds the sequence of maximal sum in given array. Example:
        // {2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  ->  {2, -1, 6, 4}
        //Can you do it with only one loop (with single scan through the elements of the array)?

        // using Kadane's algorithm 
        //http://en.wikipedia.org/wiki/Maximum_subarray_problem

        int[] array = { 2, 3, -5, -1, 2, -1, 6, 4, -8, 7 };
        //int[] array = { -11, -1, -2, -3 ,-4 ,-3};

        int maxSoFar = array[0],
            maxEndHere = array[0],
            begin = 0,
            beginTemp = 0,
            end = 0;

        for (int i = 1; i < array.Length; i++)
        {
            maxEndHere = maxEndHere + array[i];
            if (array[i] > maxEndHere)
            {
                maxEndHere = array[i];
                beginTemp = i;
            }

            if (maxEndHere > maxSoFar)
            {
                maxSoFar = maxEndHere;
                begin = beginTemp;
                end = i;
            }
        }

        PrintArray(array, 0, array.Length-1);
        PrintArray(array, begin, end);

    }
    static void PrintArray(int[] array, int begin, int end)
    {
        Console.Write("{");

        for (int i = begin; i < end; i++)
        {
            Console.Write(array[i] + ", ");
        }
        Console.Write(array[end] + "}");

        Console.WriteLine();
        
    }
}
