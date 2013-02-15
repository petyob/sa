using System;

class Program
//Write a program that reads a rectangular matrix of size N x M 
//and finds in it the square 3 x 3 that has maximal sum of its elements.
{
    static void Main()
    {
        int[,] matrix ={ {-11, 2, 3, 4 }, 
                        { 1, 1, 3, 4 }, 
                        { 1, 2, 5, 4 }, 
                        { 1, 3, 3, 4 }, 
                        { 11, 2, 3, 4 }};

        int colLegth = 4,
            rowLegth = 5;
        int sum = 0,
            maxSum = int.MinValue,
            maxRow = 0,
            maxCol = 0;

        PrintMatrix(matrix, 0, 0, rowLegth, colLegth);
        Console.WriteLine();


        for (int row = 0; row < rowLegth - 2; row++)
        {
            for (int col = 0; col < colLegth - 2; col++)
            {
                sum = SumPlatform(matrix, row, col);

                if (sum > maxSum)
                {
                    maxSum = sum;
                    maxRow = row;
                    maxCol = col;
                }

            }
        }

        Console.WriteLine("MaxPlatform starts from: ({0}, {1}), Sum= {2}", maxRow, maxCol, maxSum);



        PrintMatrix(matrix, maxRow, maxCol, 3, 3);
        

    }

    private static void PrintMatrix(int[,] matrix, int startRow, int startCol, int rows, int cols)
    {
        for (int row = startRow; row < startRow + rows; row++)
        {            for (int col = startCol; col < startCol + cols; col++)
            {
                Console.Write(matrix[row, col] + ", ");

            }

            Console.WriteLine();
        }
    }

    private static int SumPlatform(int[,] matrix, int row, int col)
    {
        int sum = 0;
        for (int m = 0; m < 3; m++)
        {
            for (int n = 0; n < 3; n++)
            {
                sum += matrix[row + m, col + n];
            }
        }
        return sum;
    }
}

