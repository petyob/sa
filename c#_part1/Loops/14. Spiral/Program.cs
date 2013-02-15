using System;

class SpiralArray
{
    static void Main()
    {
        Console.Write("n: ");
        int number = int.Parse(Console.ReadLine());
        int[,] array = new int[number, number];
        int counter = 1;
        int row = 0;
        int colum = 0;
        int toRow = number - 1;
        int toColum = number - 1;
        do
        {
            for (int i = colum; i <= toColum; i++)
            {
                array[row, i] = counter;                               // right
                counter++;
            }
            row++;
            for (int i = row; i <= toRow; i++)
            {
                array[i, toColum] = counter;                             // down
                counter++;
            }
            toColum--;
            for (int i = toColum; i >= colum; i--)
            {
                array[toRow, i] = counter;                             //left
                counter++;
            }
            toRow--;
            for (int i = toRow; i >= row; i--)
            {
                array[i, colum] = counter;                                //up
                counter++;
            }
            colum++;
        }
        while (counter <= number * number);

        for (int rows = 0; rows < number; rows++)
        {
            for (int cols = 0; cols < number; cols++)
            {
                Console.Write("{0,4}",array[rows, cols] + " ");
            }
            Console.WriteLine();
        }

    }
}