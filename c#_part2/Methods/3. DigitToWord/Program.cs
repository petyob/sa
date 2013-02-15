using System;

class Program
// method that returns the last digit of given integer as an English word. 
//Examples: 512  "two", 1024  "four", 12309  "nine".
{
    public enum Digit
    {
        zero,
        one,
        two,
        three,
        four,
        five,
        six,
        seven,
        eight,
        nine
    }

    static void Main()
    {
        Console.Write("Enter integer number: ");

        int n = int.Parse(Console.ReadLine());

        Digit anwer = LastDigitToWord(n);

        Console.WriteLine(anwer);


    }

    private static Digit LastDigitToWord(int n)
    {
        int end = n % 10;

        Digit anwer = (Digit)end;

        return anwer;
    }
}

