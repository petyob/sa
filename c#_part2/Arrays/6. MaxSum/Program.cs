using System;

class Program
// reads two integer numbers N and K and an array of N elements from the console. 
// Find in the array those K (sequensial!?) elements that have maximal sum.
{
    static void Main()
    {
        //Read the array from the console

        //Console.WriteLine("Enter the array's length: ");
        //int n = int.Parse(Console.ReadLine());


        //int[] numbers = new int[n];

        //for (int i = 0; i < n; i++)
        //{
        //    Console.Write("numbers[{0}] = ", i);
        //    numbers[i] = int.Parse(Console.ReadLine());
        //}

        int[] numbers = { 2, 1, -10, 2, 5, 3, 4, 1, 2, 1 }; 

        int n = numbers.Length;

        Console.Write("Enter number of elements(K<{0}): ",n);
        int k = int.Parse(Console.ReadLine());

        int maxSum = 0;
        int position = 0; // Where starts K elements

        for (int i = 0; i < k; i++)  // Get sum of first K element
        {
            maxSum += numbers[i];
            
        }

        int sum = maxSum; // current sum

        for (int i = 1; i < (n - k); i++)
        {
            sum = sum - numbers[i - 1] + numbers[i + k -1]; // move the K elements with 1 position forward

            if (sum > maxSum)
            {
                maxSum = sum;
                position = i;   
            }

        }

        //Print result
        for (int i = position; i < (position + k) ; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();

        Console.WriteLine("maxSum= " + maxSum);


    }
}

