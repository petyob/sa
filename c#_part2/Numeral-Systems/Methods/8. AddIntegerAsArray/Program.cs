using System;

class Program
// Write a method that adds two positive integer numbers represented as arrays of digits 
//(each array element arr[i] contains a digit; the last digit is kept in arr[0]).
//Each of the numbers that will be added could have up to 10 000 digits.
{
    static void Main()
    {
        byte[] number1 = { 1, 2, 3, 4, 5, 6, 1, };
        byte[] number2 = { 0, 1, 2, 3, 4, 5, 6, 1 };

        PrintNumber(number1);
        PrintNumber(number2);
        PrintNumber(SumArray(number1, number2));

    }

    static byte[] SumArray(byte[] number1, byte[] number2)
    {
        byte[] shorter, longer;

        byte prenos = 0;

        if ((number1.Length - number2.Length) > 0)
        {
            longer = number1;
            shorter = number2;
        }
        else
        {
            longer = number2;
            shorter = number1;
        }

        byte[] sum = new byte[longer.Length + 1];

        for (int i = 0; i < shorter.Length; i++)
        { // The rule for summing

            sum[i] = (byte)(shorter[i] + longer[i] + prenos);
            if (sum[i] > 9)
            {
                prenos = 1;
            }

            sum[i] %= 10;
        }

        for (int j = shorter.Length; j < longer.Length; j++)
        {

            sum[j] = (byte)(longer[j] + prenos);

            if (sum[j] > 9)
            {
                prenos = 1;
            }
            else
            {
                prenos = 0;
            }

            sum[j] %= 10;
        }

        return sum;
    }

    private static void PrintNumber(byte[] arr)
    {
        int start = arr.Length - 1; // The firts digit
        while (arr[start] == 0) // Skip starting "0"
        {
            start--;
        }
        for (int i = start; i >= 0; i--)
        {
            Console.Write(arr[i]);
        }
        Console.WriteLine();
    }
}

