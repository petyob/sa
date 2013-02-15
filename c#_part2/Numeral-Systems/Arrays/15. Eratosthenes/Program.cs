using System;
using System.Text;

class Program
//Finds all prime numbers in the range [1,...,10 000 000]. 
//Use the sieve of Eratosthenes algorithm.
{
    static void Main()
    {
        bool[] numbers = new bool[10000000];
        int lenght = numbers.Length; // To use this in loops bellow

        for (int i = 2; i * i <= lenght; i++)
        {
            if (!numbers[i])
            {
                for (int j = i * i; j < lenght; j += i)
                {
                    numbers[j] = true;
                }
            }
        }

        // Print results
        StringBuilder output = new StringBuilder();

        for (int i = 2; i < lenght; i++)
        {
            if (!numbers[i])
            {
                output.Append(i).Append(", ");
            }

        }
        Console.WriteLine(output);
    }
}

