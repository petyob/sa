using System;

class Program
//You are given a sequence of positive integer values written into a string, separated by spaces. 
//Write a function that reads these values from given string and calculates their sum. 
//Example: string = "43 68 9 23 318"  result = 461
{
    static void Main()
    {
        string input = " 43 68 9  23  318";
        input = input.Trim(); // remove spaces before and after

        Console.WriteLine(Sum(input));
    }

    static int Sum(string input)
    {
        string[] arr = input.Split(' ');

        int sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (!(arr[i] == string.Empty))
            {
                sum = sum + int.Parse(arr[i]);
            }
           
        }

        return sum;
    }
}

