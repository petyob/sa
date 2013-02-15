using System;

class Program
// finds the maximal sequence of equal elements in an array.
//	Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.
{
    static void Main()
    {
        int[] numbers = { 2, 1, 1, 1, 2, 3, 3, 2, 2, 2, 2 };

        // Read the array from the console
        //
        //Console.WriteLine("Enter the array's length:");
        //int n = int.Parse(Console.ReadLine());

        //int[] numbers = new int[n];

        //for (int i = 0; i < n; i++)
        //{
        //    Console.Write("numbers[{0}] = ", i);
        //    numbers[i] = int.Parse(Console.ReadLine());
        //}

        int n = numbers.Length;

        for (int i = 0; i < n; i++)
        {
            Console.Write(numbers[i] + " ");

        }
        Console.WriteLine();

        int len = 1; // lenght of the sequence
        int bestStart = 0; // Best start position of equal elements
        int bestLen = 1; // best lenght of the sequence

        for (int i = 1; i < n; i++)
        {
            if (numbers[i] == numbers[i - 1])
            {
                len++;
            }
            else
            {
                len = 1;
            }

            if (len > bestLen) // Here we have a new best sequence
            {
                bestLen = len;
                bestStart = i - bestLen + 1;
            }
                        
        }

        
        //Console.WriteLine(bestStart +", " +bestLen);
        for (int i = bestStart; i < bestStart+bestLen; i++)
        {
            Console.Write(numbers[i] + " ");

        }


    }
}
