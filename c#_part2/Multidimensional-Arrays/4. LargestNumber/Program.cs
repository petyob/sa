using System;

class Program
// Write a program, that reads from the console an array of N integers and an integer K,
//sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 
{
    static void Main()
    {
        while (true)
        {
            // Generate Array with random numbers
            Console.WriteLine("Generate Array:");
            int lenght = 10;
            int[] numbers = new int[lenght];
            Random random = new Random();

            for (int i = 0; i < lenght; i++)
            {
                numbers[i] = (int)random.Next(0, 100);
            }

            Array.Sort(numbers);
            for (int i = 0; i < lenght; i++)
            {
                Console.Write(numbers[i] + ", ");
            }
            Console.WriteLine();

            Console.Write("Number to find: ");
            int aNumber = int.Parse(Console.ReadLine());

            int index = Array.BinarySearch(numbers, aNumber);
            // The index of the specified value in the specified array, if value is found. 
            //If value is not found and value is less than one or more elements in array, 
            //a negative number which is the bitwise complement of the index of the first element that is larger than value. 
            //If value is not found and value is greater than any of the elements in array, 
            //a negative number which is the bitwise complement of (the index of the last element plus 1).

            if (index < 0)
            {
                if (index == -1)
                {
                    Console.WriteLine("There is no number <={0}.", aNumber);
                }
                else
                {
                    Console.WriteLine("{0} is the largest number in the array which is <= {1}", numbers[~index - 1], aNumber);
                }
            }
            else
            {
                Console.WriteLine(numbers[index]);
            }
            Console.WriteLine();
        }

    }
}

