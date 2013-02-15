using System;

class Program
// Write a method that checks if the element at given position in given array of integers 
// is bigger than its two neighbors (when such exist).
{
    static void Main()
    {
        int[] numbers = { 2, 5, 7, 45, 6, 1, 3, 4, 2, 4, 5, 3, 2, 3, 4, 5, 7 };

        do
        {
            Console.WriteLine("Position: ");
            int position = int.Parse(Console.ReadLine());

            Console.WriteLine("if the element at position {0} is bigger than its two neighbors? {1}",
            position,
            CheckIsBigger(numbers, position));

        } while (true);

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

