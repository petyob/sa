using System;

class Program
// finds the maximal increasing sequence in an array
{
    static void Main()
    {
        int[] numbers = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1, 0, -1, 0, 1, 2, 3 };

        int n = numbers.Length;

        for (int i = 0; i < n; i++)
        {
            Console.Write(numbers[i] + " ");

        }
        Console.WriteLine();

        int len = 1; // lenght of the increasing sequence
        int bestStart = 0; // Best start position 
        int bestLen = 1; // best lenght 

        for (int i = 1; i < n; i++)
        {
            if (numbers[i] == (numbers[i - 1] + 1))
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
        Console.WriteLine("maximal increasing sequence:");
        for (int i = bestStart; i < bestStart + bestLen; i++)
        {
            Console.Write(numbers[i] + " ");

        }
    }
}

