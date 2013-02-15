using System;

class Program
//Use the "selection sort" algorithm: 
//Find the smallest element, move it at the first position, 
//find the smallest from the rest, move it at the second position, etc.
{   
    static void Main()
    {
        int[] numbers = { 2, 1, -10, 20, 5, 33, 4, 1, 2, 1 };

        int swaps = 0;
        int length = numbers.Length;

        Console.WriteLine("Non sorted:");
        for (int i = 0; i < length; i++)
        {
            Console.Write(numbers[i] + " ");

        }
        Console.WriteLine();

        for (int i = 0; i < length; i++)
        {
            int min = i;  // index of the minnimal element
            int minElement = numbers[min]; //Remember the current "min" to avoid multiple accesing the element for comparing
            
            for (int k = (i + 1) ; k < length; k++)
            {
                if (numbers[k] < minElement)
                {
                    min = k;
                    minElement = numbers[min];
                }
            }

            //Swap elements
            int temp = numbers[i];
            numbers[i] = numbers[min];
            numbers[min] = temp;
            swaps++;
                      
        }

        Console.WriteLine("Sorted:");
        for (int i = 0; i < length; i++)
        {
            Console.Write(numbers[i] + " ");
            
        }

        Console.WriteLine( swaps);
   
    }
}

