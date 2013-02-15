using System;

class Program
// Write a method that return the maximal element in a portion of array of integers starting at given index.
// Using it write another method that sorts an array in ascending / descending order.
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 3, 4, 5, 2, 5, 6, 3, 6, 2 };

        Sort(numbers);

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }

    }

    private static void Sort(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            int index = GetMaxIndex(numbers, i);
            //swap elements
            int temp = numbers[i];
            numbers[i] = numbers[index];
            numbers[index] = temp;
        }
    }

    private static int GetMaxIndex(int[] numbers, int position)
    //Return the maximal element in a portion of array of integers starting at given index.
    {
        int max = numbers[position];
        int index = position;

        for (int i = position + 1; i < numbers.Length; i++)
        {
            if (max < numbers[i])
            {
                max = numbers[i];
                index = i;
            }

        }
        return index;
    }
}

