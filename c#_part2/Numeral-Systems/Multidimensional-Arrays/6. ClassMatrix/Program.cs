using System;
using System.Text;

class Program
//Write a class Matrix, to holds a matrix of integers.
//Overload the operators for adding, subtracting and multiplying of matrices,
//indexer for accessing the matrix content and ToString().
{
    static void Main()
    {
        try
        {
            Matrix m1 = new Matrix(3, 4);
            Console.WriteLine("m1:");
            Console.WriteLine(m1.ToString());

            Matrix m2 = new Matrix(3, 4);
            Console.WriteLine("m2:");
            Console.WriteLine(m2.ToString());

            Console.WriteLine("(m1 + m2):");
            Console.WriteLine((m1 + m2).ToString());

            Console.WriteLine("(m1 - m2):");
            Console.WriteLine((m1 - m2).ToString());

            Matrix m3 = new Matrix(4, 4);
            Console.WriteLine("m3:");
            Console.WriteLine(m3.ToString());

            Console.WriteLine("(m1 * m3):");
            Console.WriteLine((m1 * m3).ToString());

        }
        catch (ArgumentException m)
        {
            Console.WriteLine("Operation cannot be performed :" + m);
            //throw;
        }
    }
}

class Matrix
{
    static Random rnd = new Random();
    private int rows;
    private int columns;
    private int[,] matrix;

    // Indexer
    public int this[int x, int y]
    {
        get
        {
            return matrix[x, y];
        }
        set
        {
            matrix[x, y] = value;
        }
    }

    //Constructor
    public Matrix(int rows, int columns)
    {
        this.rows = rows;
        this.columns = columns;
        this.matrix = new int[rows, columns];
        for (int row = 0; row < rows; row++) // Generate random elements
        {
            for (int col = 0; col < columns; col++)
            {
                this.matrix[row, col] = rnd.Next(10);
            }
        }
    }

    //Overload ToString
    public new string ToString()
    {
        StringBuilder matrixStr = new StringBuilder();

        for (int row = 0; row < this.rows; row++)
        {
            for (int column = 0; column < this.columns; column++)
            {
                matrixStr.Append(this[row, column].ToString().PadLeft(4));
            }
            matrixStr.Append("\r\n");
        }
        matrixStr.Append("\r\n"); 
        return matrixStr.ToString();
    }

    // adding
    public static Matrix operator +(Matrix m1, Matrix m2)
    {
        if (!(m1.rows == m2.rows) || !(m1.columns == m2.columns))
        {
            throw new System.ArgumentException("The sizes don't allow adding");
        }
        Matrix result = new Matrix(m1.rows, m1.columns);

        for (int row = 0; row < m1.rows; row++)
        {
            for (int col = 0; col < m1.columns; col++)
            {
                result[row, col] = m1[row, col] + m2[row, col];
            }
        }
        return result;
    }

    //subtracting
    public static Matrix operator -(Matrix m1, Matrix m2)
    {
        if (!(m1.rows == m2.rows) || !(m1.columns == m2.columns))
        {
            throw new System.ArgumentException("The sizes don't allow subtracting");
        }

        Matrix result = new Matrix(m1.rows, m1.columns);

        for (int row = 0; row < m1.rows; row++)
        {
            for (int col = 0; col < m1.columns; col++)
            {
                result[row, col] = m1[row, col] - m2[row, col];
            }
        }
        return result;
    }

    //multiplying
    public static Matrix operator *(Matrix m1, Matrix m2)
    {
        if (!(m1.columns == m2.rows))
        {
            throw new System.ArgumentException("The sizes don't allow multiplying");
        }

        Matrix resultMatrix = new Matrix(m1.rows, m2.columns);

        for (int row = 0; row < m1.rows; row++)
        {
            for (int col = 0; col < m2.columns; col++)
            {
                int sum = 0;
                for (int i = 0; i < m1.columns; i++)
                {
                    sum += m1[row, i] * m2[i, col];
                }
                resultMatrix[row, col] = sum;
            }
        }
        return resultMatrix;
    }
}

