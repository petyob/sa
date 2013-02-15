using System;

class Program
// Write a method that returns the index of the first element in array 
//that is bigger than its neighbors, or -1, if there’s no such element.
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 4 };

        Console.WriteLine(IndexOfFirstBigger(numbers));

    }

    private static int IndexOfFirstBigger(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            if (CheckIsBigger(numbers, i))
            {
                return i;
            }
        }
        return -1;
    }

    private static bool CheckIsBigger(int[] numbers, int position)
    {
        bool isBigger = false;

        if ((position >= 1) && (position < numbers.Length - 1))
        {
            if ((numbers[position - 1] < numbers[position]) && (numbers[position + 1] < numbers[position]))
            {
                isBigger = true;
            }
        }

        return isBigger;
    }
}

