using System;

class Program
//Finds in given array of integers a sequence of given sum S (if present).
//Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}
{
    static void Main()
    {
        int[] numbers = {4, 3, 1, 4, 2, 5, 8, 11};
        int s = 11;

        // Go trought all the combination and check the sum
        for (int i = 0; i < numbers.Length; i++)
        {

            for (int m = i, sum = 0; m < numbers.Length; m++)
            {
                sum = sum + numbers[m];

                if ( sum == s) // Print a solution
                {
                    for (int k = 0, l = m - i + 1; k < l; k++)
                    {
                        Console.Write(numbers[i + k] + " ");
                    }
                    Console.WriteLine();
                }

            }

        }

    }
}