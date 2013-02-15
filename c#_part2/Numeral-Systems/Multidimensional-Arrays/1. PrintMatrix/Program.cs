using System;

class Program
//Write a program that fills and prints a matrix of size (n, n) as shown below:
{
    static void Main()
    {
        int size = 4;
        int[,] matrix = new int[size, size];

        int start = 1;

        FillMatrixA(size, matrix, start);
        PrintMatrix(size, matrix);

        FillMatrixB(size, matrix, start);
        PrintMatrix(size, matrix);

        FillMatrixC(size, matrix, start);
        PrintMatrix(size, matrix);

        FillMatrixD(size, matrix, start);
        PrintMatrix(size, matrix);

    }

    private static void PrintMatrix(int length, int[,] matrix)
    {
        for (int row = 0; row < length; row++)
        {
            for (int col = 0; col < length; col++)
            {
                Console.Write("{0,3}", matrix[row, col]);
            }
            Console.WriteLine();

        }
    }
    private static void FillMatrixA(int length, int[,] matrix, int i)
    {
        Console.WriteLine("A");
        for (int col = 0; col < length; col++)
        {
            for (int row = 0; row < length; row++)
            {
                matrix[row, col] = i++;
            }
        }


    }

    private static void FillMatrixB(int length, int[,] matrix, int i)
    {
        Console.WriteLine("B");
        for (int col = 0; col < length; col++)
        {
            if ((col & 1) == 0)
            {
                for (int row = 0; row < length; row++)
                {
                    matrix[row, col] = i++;
                }
            }
            else
            {
                for (int row = length - 1; row >= 0; row--)
                {
                    matrix[row, col] = i++;
                }
            }
        }
    }

    private static void FillMatrixC(int length, int[,] matrix, int i)
    {
        Console.WriteLine("C");

        for (int row = length - 1; row >= 0; row--)
        {
            for (int col = 0; col < length - row; col++)
            {
                matrix[row + col, col] = i++;
            }
        }
        for (int col = 1; col < length; col++)
        {
            for (int row = 0; row < length - col; row++)
            {
                matrix[row, col + row] = i++;
            }
        }

    }

    private static void FillMatrixD(int length, int[,] matrix, int i)
    {
        Console.WriteLine("D");

        int row = 0;
        int colum = 0;
        int toRow = length - 1;
        int toColum = length - 1;

        do
        {
            for (int k = row; k <= toRow; k++)
            {
                matrix[k, colum] = i++;            // down
            }
            colum++;

            for (int k = colum; k <= toColum; k++)
            {
                matrix[toRow, k] = i++;            // right
            }
            toRow--;

            for (int k = toRow; k >= row; k--)
            {
                matrix[k, toColum] = i++;          //up

            }
            toColum--;

            for (int k = toColum; k >= colum; k--)
            {
                matrix[row, k] = i++;             //left               
            }
            row++;

        }
        while (i <= length * length);
    }


}
