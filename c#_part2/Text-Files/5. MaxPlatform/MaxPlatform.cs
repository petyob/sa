using System;
using System.IO;

//Write a program that reads a text file containing a square matrix of numbers 
//and finds in the matrix an area of size 2 x 2 with a maximal sum of its elements. 
//The first line in the input file contains the size of matrix N. 
//Each of the next N lines contain N numbers separated by space. 
//The output should be a single number in a separate text file. Example:

class MaxPlatform
{
    static void Main()
    {
        int n;
        int[,] matrix;
        using (StreamReader reader = new StreamReader("../../Matrix.txt"))
        {
            n = int.Parse(reader.ReadLine());
            matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] row = reader.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                    matrix[i, j] = int.Parse(row[j]);
            }
        }

        int maxSum = CalcMaxPlatform(matrix);

        using (StreamWriter output = new StreamWriter("../../output.txt"))
        {
            output.WriteLine(maxSum);
        }
    }

    private static int CalcMaxPlatform(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        int sum = 0,
         maxSum = int.MinValue,
         maxRow = 0,
         maxCol = 0;

        for (int row = 0; row < n - 1; row++)
        {
            for (int col = 0; col < n - 1; col++)
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
        return maxSum;
    }

    private static int SumPlatform(int[,] matrix, int row, int col)
    {
        int sum = 0;
        for (int m = 0; m < 2; m++)
        {
            for (int n = 0; n < 2; n++)
            {
                sum += matrix[row + m, col + n];
            }
        }
        return sum;
    }
}
