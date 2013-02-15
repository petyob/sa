using System;

class Program
//Finds the index of given element in a sorted array of integers by using the binary search algorithm.
{
    static void Main()
    {
        // Generate Array with random numbers
        Console.WriteLine("Generate Array .....");
        int lenght = 10000000;
        int[] numbers = new int[lenght];
        Random random = new Random();

        for (int i = 0; i < lenght; i++)
        {
            numbers[i] = (int)random.Next(0, 1000000);
        }

        Array.Sort(numbers);

        Console.Write("Number to find: ");
        int aNumber = int.Parse(Console.ReadLine());

        // Compare performance of 4 methods. Binary search is up to 40 times faster then Array.IndexOf !!!!

        // Calculate the time 
        DateTime start, end;
        TimeSpan interval;
        start = DateTime.Now;

        int index = BinarySearch(numbers, aNumber);

        Console.WriteLine("Index : " + index);

        // Calculate the time
        end = DateTime.Now;
        interval = end - start;
        Console.WriteLine("Work time: " + interval);

        //------------- Second Method --------------------------------

        // Calculate the time 
        start = DateTime.Now;

        index = Array.IndexOf(numbers, aNumber, 0);

        Console.WriteLine("Index : " + index);

        // Calculate the time
        end = DateTime.Now;
        interval = end - start;
        Console.WriteLine("Work time: " + interval);

        //------------- 3 Method -binary search + Recusrion --------------------------------

        // Calculate the time 
        start = DateTime.Now;

        index = BinarySearch(numbers, aNumber, 0, lenght);

        Console.WriteLine("Index : " + index);

        // Calculate the time
        end = DateTime.Now;
        interval = end - start;
        Console.WriteLine("Work time: " + interval); 

        //------------- 4 Method - use binary search class --------------------------------

        // Calculate the time 
        start = DateTime.Now;

        index = Array.BinarySearch (numbers, aNumber);

        while (aNumber == numbers[index])  // Get the first element of equal
        {
            index--;
        }

        Console.WriteLine("Index : " + (index+1));

        // Calculate the time
        end = DateTime.Now;
        interval = end - start;
        Console.WriteLine("Work time: " + interval);

    }

    static int BinarySearch(int[] numbers, int aNumber)
    {
        int index = -1; // -1 - not found.
        int min = 0,
            max = numbers.Length;
        int mid;

        do
        {
            mid = (min + max) / 2;

            if (numbers[mid] > aNumber)
            {
                max = mid - 1;
            }
            else if (numbers[mid] < aNumber)
            {
                min = mid + 1;
            }
            else
            {
                while (numbers[mid] == aNumber)  // find index of the first of equal
                {
                    mid--;
                }
                index = mid + 1;

            }

        } while ((min < max) && index == -1);
        return index;
    }

    static int BinarySearch(int[] array, int number, int min, int max)
    {
        if ( (min > max) || (min < 0) || (max > array.Length) )
        {
            return -1;
        }

        int middleElement = (min + max) / 2;

        if (number > array[middleElement])
        {
            min = middleElement + 1;
        }
        else if (number < array[middleElement])
        {
            max = middleElement - 1;
        }
        else 
        {
            while (number == array[middleElement]) // Get the first element of equal
            {
                middleElement--;
            }
            return middleElement + 1;
        }

        return BinarySearch(array, number, min, max);
    }


}

