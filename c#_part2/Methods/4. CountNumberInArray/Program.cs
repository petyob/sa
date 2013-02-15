using System;

class Program
// Write a method that counts how many times given number appears in given array. 
// Write a test program to check if the method is working correctly.
{
    static void Main()
    {
        int[] numbers = { 2, 5, 7, 45, 6, 1, 3, 4, 2, 4, 5, 3, 2, 3, 4, 5, 7 };
        Console.WriteLine("Number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Count = " + CountNumberInArray(numbers, number)); 

    }

    static int CountNumberInArray(int[] numbers, int number)
    {
        int count = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == number)
            {
                count++;

            }
        }

        return count;
    }
}

