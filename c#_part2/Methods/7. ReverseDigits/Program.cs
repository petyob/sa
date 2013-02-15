using System;

class Program
// Write a method that reverses the digits of given decimal number. 
// Example: 256  652
{
    static void Main()
    {
        while (true)
        {
            decimal number = decimal.Parse(Console.ReadLine());

            Console.WriteLine(ReverseDigits(number));          
        }

    }

    static string ReverseDigits(decimal number)
    {
        string strNumber = number.ToString();

        string reverse = string.Empty;

        for (int i = 0; i < strNumber.Length; i++)
        {
            if ((strNumber[i] != '.') && (strNumber[i] != '-'))
            {
                reverse = strNumber[i] + reverse;
            }
        }
        return reverse;
    }
}

