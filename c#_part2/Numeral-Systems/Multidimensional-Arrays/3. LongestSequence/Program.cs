using System;

class Program
//We are given a matrix of strings of size N x M. Sequences in the matrix we define 
//as sets of several neighbor elements located on the same line, column or diagonal. 
//Write a program that finds the longest sequence of equal strings in the matrix
{
    static int bestLength = 1;
    static string bestString;
    static int[,] directions = { { 0, 1 }, { 1, 0 }, { 1, 1 }, { 1, -1 } }; // {right, down, right+down, left+down}

    static void Main(string[] args)
    {
        string[,] matrix = { { "ha", "fi", "hi", "xx" }, 
                            { "fo", "ha", "hi", "xx" }, 
                            { "xxx", "hi", "h", "xx" } };

        int lastRow = matrix.GetLength(0) - 1;
        int lastCol = matrix.GetLength(1) - 1;

        // Search over all direction
        for (int i = 0; i <= lastRow; i++)
        {
            SearchDirection(matrix, i, 0, 0);  //rows (i,0) -> right
            SearchDirection(matrix, i, 0, 2);  //rows (i,0) -> r+d 
            SearchDirection(matrix, i, lastCol, 3);  //last colom (i,Last)-> left+down
        }

        for (int j = 0; j <= lastCol; j++)
        {
            SearchDirection(matrix, 0, j, 1);  //columns -> down
            SearchDirection(matrix, 0, j, 2);  //columns -> r+d
            SearchDirection(matrix, 0, j, 3);  //columns -> left+down
        }

        for (int i = 0; i + 1 < bestLength; i++) Console.Write(bestString + ", ");
        Console.WriteLine(bestString);
    }

    static void SearchDirection(string[,] matrix, int row, int col, int direction)
    {
        int curRow = row, curCol = col, curLength = 1;
        string patern = matrix[row, col];

        while (true)
        {
            curRow += directions[direction, 0];
            curCol += directions[direction, 1];

            if (curRow < 0 || curRow >= matrix.GetLength(0) || curCol < 0 || curCol >= matrix.GetLength(1))
            {
                break;
            }

            if (matrix[curRow, curCol] != patern)
            {
                if (curLength > bestLength)
                {
                    bestLength = curLength;
                    bestString = patern;
                }
                curLength = 1;
                patern = matrix[curRow, curCol];
            }
            else
            {
                curLength++;
            }
        }
        if (curLength > bestLength)
        {
            bestLength = curLength;
            bestString = patern;
        }
    }
}
