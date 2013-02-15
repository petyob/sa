using System;

class Program
//Program that sorts an array of integers using the merge sort algorithm (find it in Wikipedia).
{
    static int[] temp;

    static void Main()
    {
        //int[] numbers = { 4, 1, 1, 4, 2, 1, 1, 1, 3, 4, 4, 1, 2, 4, 9, 3 };
        // Generate Array with random numbers
        Console.WriteLine("Generate Array .....");
        int length = 1000000;
        int[] numbers = new int[length];
        temp = new int[length];

        Random random = new Random();

        for (int i = 0; i < length; i++)
        {
            numbers[i] = (int)random.Next(0, 1000000);
        }

        int[] numbersCopy = new int[length];
        for (int i = 0; i < length; i++)
        {
            numbersCopy[i] = numbers[i];
        }

        // Calculate the time 
        DateTime start = DateTime.Now;

        MergeSort(numbers, 0, numbers.Length - 1);

        // Calculate the time
        TimeSpan interval;
        DateTime end = DateTime.Now;
        interval = end - start;
        Console.WriteLine("Work time: " + interval);

        //------------- Second Method --------------------------------

        // Calculate the time 
        start = DateTime.Now;

        MergeSort(ref numbersCopy, 0, numbersCopy.Length-1); // Overload method

        // Calculate the time
        end = DateTime.Now;
        interval = end - start;
        Console.WriteLine("Work time: " + interval);

        //Verify if both results are equal
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

    static void MergeArrayParts(int[] arr, int left, int middle, int right) 
    // Merge [left,middle] with [middle+1,right] parts
    {
        int i = left, j = middle + 1, k = left;
        

        while (i <= middle && j <= right)
        {
            temp[k++] = (arr[i] < arr[j]) ? arr[i++] : arr[j++];
        }

        while (i <= middle) temp[k++] = arr[i++];
        while (j <= right) temp[k++] = arr[j++];

        Array.Copy(temp, left, arr, left, right - left + 1); //Copy temp values to the original

    }

    static void MergeSort(int[] arr, int left, int right) 
    {

        if (left >= right) return;

        int middle = (left + right) / 2;

        MergeSort(arr, left, middle);
        MergeSort(arr, middle + 1, right);

        MergeArrayParts(arr, left, middle, right); // Merge [left,middle] with [middle+1,right]
    }


    public static void MergeSort(ref int[] x, int left, int right)
    {
        if (left < right)
        {
            int middle = (left + right) / 2;
            MergeSort(ref x, left, middle);
            MergeSort(ref x, middle + 1, right);
            Merge(ref x, left, middle, middle + 1, right);
        }
    }

    public static void Merge(ref int[] x, int left, int middle, int middle1, int right)
    {
        int oldPosition = left;
        int size = right - left + 1;
        int[] temp = new int[size];
        int i = 0;

        while (left <= middle && middle1 <= right)
        {
            if (x[left] <= x[middle1])
                temp[i++] = x[left++];
            else
                temp[i++] = x[middle1++];
        }

        if (left > middle)
            for (int j = middle1; j <= right; j++)
                temp[i++] = x[middle1++];
        else
            for (int j = left; j <= middle; j++)
                temp[i++] = x[left++];
        Array.Copy(temp, 0, x, oldPosition, size);
    }
}

