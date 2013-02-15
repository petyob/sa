using System;

class Program
//We are given an array of integers and a number S. 
//Write a program to find if there exists a subset of the elements of the array that has a sum S. 
//Example:	arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14  -> yes (1+2+5+6)
{

    public static int GetBit(int number, int posittion)
    {
        return (number & (1 << posittion)) >> posittion; // return the bit at "posittion"
    }

    static void Main(string[] args)
    {
        int[] numbers = { 2, 1, 2, 4, 3, 5, 2, 6 };
        int subsetSum = 14;
        int bit;

        double allSubsets = Math.Pow(2, numbers.Length); // will use a as binary number

        for (int i = 1; i < allSubsets; i++)
        {
            int sum = 0;

            for (int k = 0; k < numbers.Length; k++) // do the subset sum
            {
                bit = GetBit(number: i, posittion: k);
                sum += numbers[k] * bit;

            }

            if (sum == subsetSum)   // Print a Solution
            {
                for (int k = 0; k < numbers.Length; k++)
                {
                    bit = GetBit(number: i, posittion: k);
                    if (bit == 1)
                    {
                        Console.Write(numbers[k] < 0 ? "" + numbers[k] : "+" + numbers[k]);
                    }

                }
                Console.WriteLine(" = " + subsetSum);
            }
        }

    }


}

