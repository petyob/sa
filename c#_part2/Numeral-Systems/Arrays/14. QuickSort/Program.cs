using System;

class Program
// Sorts an array of strings using the quick sort algorithm,
{
    static void SwapElements(int[] arr, int i, int j)
    {
        if (i == j) return;

        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

    static int Partition(int[] arr, int left, int right, int pivotIndex)
    {
        SwapElements(arr, pivotIndex, right); // Move pivot to end
        
        int pivot = arr[right];
        int storeIndex = left;

        for (int i = left; i < right; i++)
        {
            if (arr[i] <= pivot)
            {
                SwapElements(arr, storeIndex++, i); // move the element before storeIndex
            }
        }

        SwapElements(arr, storeIndex, right); // Move pivot to its final place

        return storeIndex; // return pivot's index
    }

    static void QuickSort(int[] arr, int left, int right)
    {
        int pivotIndex;

        if (right > left) // Termination condition
        {
            pivotIndex = right; // "Choice of pivot" 

            pivotIndex = Partition(arr, left, right, pivotIndex); // Get 2 parts of bigger and smaller items and final position of pivot

            QuickSort(arr, left, pivotIndex - 1); // Recursivly sort elements smaller than the pivot
            QuickSort(arr, pivotIndex + 1, right); // Recursivly sort elements at least as big as the pivot
        }
    }

    static void Main()
    {
        //int[] numbers = { 4, 1, 1, 4, 2, 1, 1, 1, 3, 4, 4, 1, 2, 4, 9, 3 };
        // Generate Array with random numbers
        Console.WriteLine("Generate Array .....");
        int length = 1000000;
        int[] numbers = new int[length];

        Random random = new Random();

        for (int i = 0; i < length; i++)
        {
            numbers[i] = (int)random.Next(0, 100000);
        }

        int[] numbersCopy = new int[length];
        for (int i = 0; i < length; i++)
        {
            numbersCopy[i] = numbers[i];
        }

        // Calculate the time 
        DateTime start = DateTime.Now;

        QuickSort(numbers, 0, length - 1);

        // Calculate the time
        TimeSpan interval;
        DateTime end = DateTime.Now;
        interval = end - start;
        Console.WriteLine("Work time: " + interval);

        //------------- Second Method --------------------------------

        // Calculate the time 
        start = DateTime.Now;

        QuickSort(ref numbersCopy);

        // Calculate the time
        end = DateTime.Now;
        interval = end - start;
        Console.WriteLine("Work time: " + interval);

        //Verification - if results of both Method are equal 
        bool verify = true;
        for (int i = 0; i < length; i++)
        {
            if (numbers[i] != numbersCopy[i])
            {
                verify = false;
                Console.WriteLine(i + " " + numbers[i] + " " + numbersCopy[i]);
                break;
            }
        }
        Console.WriteLine("Results are equal: " + verify);

    }

    public static void QuickSort(ref int[] arr)
    {
        qs(arr, 0, arr.Length - 1);
    }

    static void qs(int[] arr, int left, int right)
    {
        int i, j;
        int pivot;

        i = left;
        j = right;
        pivot = arr[(left + right) / 2]; // "Choice of pivot" 

        do
        {
            // Skip the elements that are in the correct side of the pivot elemnt
            while ((arr[i] < pivot) && (i < right))
            {
                i++; 
            }

            while ((pivot < arr[j]) && (j > left))
            {
                j--;
            }

            // Swap 2 elements - arr[i] < pivot < arr[j]
            if (i <= j)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++; j--;
            }

        } while (i <= j);

        if (left < j)
        {
            qs(arr, left, j); // Sort left sub-array
        }

        if (i < right)
        {
            qs(arr, i, right); // Sort right sub-array
        } 
    }
}