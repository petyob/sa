using System;
using System.Collections.Generic;

class Program
//Write a program that finds the largest area of equal neighbor elements in a rectangular matrix and prints its size.
{
    static Random rnd = new Random();

    static void Main()
    {
        int rows = 6;
        int columns = 6;
        int[,] matrix = new int[rows, columns];

        GetMatrix(matrix, rows, columns);

        //int[,] matrix = new int[,] 
        //    { { 1, 3, 3, 4, 2, 4 },
        //    { 3, 3, 1, 3, 4, 4 },
        //    { 4, 1, 1, 2, 3, 3 }, 
        //    { 4, 3, 1, 3, 3, 1 },
        //    { 4, 3, 3, 1, 1, 1 } };

        //int rows = matrix.GetLength(0);
        //int columns = matrix.GetLength(1);

        bool[,] visited = new bool[rows, columns];

        int maxLength = 0;
        int maxElement = int.MinValue;

        int[][] directions = {                          // row and column change
                             new int[] { 1, 0 },  
                             new int[] { 0, 1 }, 
                             new int[] { -1, 0 }, 
                             new int[] { 0, -1 } };

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns; col++)
            {
                if (visited[row, col])
                {
                    continue;
                }

                visited[row, col] = true;
                int currentLength = 1;
                Queue<int> cells = new Queue<int>();
                cells.Enqueue(row); // Push the cell
                cells.Enqueue(col);

                while (cells.Count > 0)
                {
                    int newRow = cells.Dequeue();
                    int newCol = cells.Dequeue();

                    foreach (var direction in directions) // Go over all directions
                    {
                        int nextRow = newRow + direction[0];
                        int nextCol = newCol + direction[1];
                        // Test the element
                        bool isInsideMatrix = (nextRow >= 0 && nextRow < rows && nextCol >= 0 && nextCol < columns);
                        if (isInsideMatrix && !visited[nextRow, nextCol] && matrix[nextRow, nextCol] == matrix[row, col])
                        { // Its OK, than Push the cell
                            currentLength++;
                            cells.Enqueue(nextRow);
                            cells.Enqueue(nextCol);
                            visited[nextRow, nextCol] = true;
                        }
                    }
                }

                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    maxElement = matrix[row, col];
                }
            }
        }

        Console.WriteLine("Largest area length is {0}, with {1}", maxLength, maxElement);
    }

    public static void GetMatrix(int[,] matrix, int rows, int columns)
    {
        for (int row = 0; row < rows; row++) // Generate random elements and print
        {
            for (int col = 0; col < columns; col++)
            {
                matrix[row, col] = rnd.Next(4);
                Console.Write("{0,3}", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}

