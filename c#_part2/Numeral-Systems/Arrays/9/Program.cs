using System;


class Program
// Write a program that finds the most frequent number in an array. 
//Example:
//{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  -> 4 (5 times)
{
    static void Main()
    {

       // int[] numbers = { 4, 1, 1, 4, 2, 1, 1, 1, 3, 4, 4, 1, 2, 4, 9, 3 };
       //int[] numbers = { 1,1,3,4,5,6,7,8,8,8 };

        //int lenght = numbers.Length;
        // Generate Array with random numbers
        int lenght = 30000;
        int[] numbers = new int[lenght];
        Random random = new Random();

        for (int i = 0; i < lenght; i++)
        {
            numbers[i] = (int)random.Next(0, 1000);
        }
        
        //for (int i = 0; i < lenght; i++)
        //{
        //    Console.Write(numbers[i] + " ");
        //}
        //Console.WriteLine();

        // Calculate the time 
        DateTime start, end;
        TimeSpan interval;
        start = DateTime.Now;

        int mostNumber = numbers[0];
         
        int mostTimes = 1;

        for (int i = 0; i < lenght; i++)
        {
            if (Array.IndexOf(numbers, numbers[i], 0) < i)
            {
                continue; // This number have alredy passed before.
            }

            int currentElement = numbers[i];
            int position = i + 1; // Will count how many time find currentElement after current position
            int currentTimes = 0;

            int indexOfTheNext; //Index of the next occurance

            do
            {
                currentTimes++;

                indexOfTheNext = Array.IndexOf(numbers, currentElement, position);

                position = indexOfTheNext + 1;

            } while (indexOfTheNext > -1); 


            if (currentTimes > mostTimes)
            {
                mostTimes = currentTimes;
                mostNumber = numbers[i];
            }

        }

        // Calculate the time
        end = DateTime.Now;
        interval = end - start;
        Console.WriteLine("Work time: " + interval);
        Console.WriteLine(mostNumber + "(" + mostTimes + " times)");


        // Second method

        start = DateTime.Now;

        Array.Sort(numbers);

        int len = 1; // lenght of the sequence
        int index = 0; // index of equal elements
        int bestLen = 1; // best lenght of the sequence

        for (int i = 1; i < lenght; i++)
        {
            if (numbers[i] == numbers[i - 1])
            {
                len++;
            }
            else
            {
                if (len > bestLen) // Here we have a new best sequence
                {
                    bestLen = len;
                    index = i - 1;
                }

                len = 1;
            }

        }

        end = DateTime.Now;
        interval = end - start;
        Console.WriteLine("Work time: "+ interval);
        Console.WriteLine(numbers[index] + "(" + bestLen + " times)");


    }
}

