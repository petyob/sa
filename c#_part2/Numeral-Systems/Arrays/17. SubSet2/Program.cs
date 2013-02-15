using System;
using System.Numerics;

class Program
{
    //Reads three integer numbers N, K and S and an array of N elements from the console. 
    //Find in the array a subset of K elements that have sum S or indicate about its absence

    static void Main(string[] args)
    {
        int[] numbers = { 2, 1, 2, 4, 3, 5, 2, 6, 1, 1, 1};
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + ", ");
        }
        Console.WriteLine();
        //int subsetSum = 14;

        // Generate Array with random numbers
        //Console.WriteLine("Generate Array .....");
        //int length = 32;
        //int[] numbers = new int[length];

        //Random random = new Random();

        //for (int i = 0; i < length; i++)
        //{
        //    numbers[i] = (int)random.Next(0, 100);
        //}

        int bit;
        bool absence = true;

        Console.Write("K = ");
        int k = int.Parse(Console.ReadLine());

        Console.Write("S = ");
        int subsetSum = int.Parse(Console.ReadLine());

        for (int i = 0; i < numbers.Length; i++)
        {
            int sum = 0, calcLenght = 0;

            for (int m = 0; m < numbers.Length; m++) // do the subset sum
            {
                bit = GetBit(number: i, posittion: m);
                calcLenght = calcLenght + bit;  // Calculate the lenght

                sum += numbers[m] * bit;

            }

            if ((sum == subsetSum) && (calcLenght == k))  // Print a Solution
            {
                for (int n = 0; n < numbers.Length; n++)
                {
                    bit = GetBit(number: i, posittion: n);
                    if (bit == 1)
                    {
                        Console.Write(numbers[n] < 0 ? "" + numbers[n] : "+" + numbers[n]);
                    }

                }
                Console.WriteLine(" = " + subsetSum);
                absence = false;
                break; // Find Only one solution 
            }
        }
        if (absence) // Not found solution
        {
            Console.WriteLine("No solution");
        }


    }

    public static int GetBit(int number, int posittion)
    {
        return (number & (1 << posittion)) >> posittion; // return the bit at "posittion"
    }
}

