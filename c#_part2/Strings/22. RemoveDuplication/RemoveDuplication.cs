using System;
using System.Text;
using System.Text.RegularExpressions;
//Write a program that reads a string from the console and replaces 
//all series of consecutive identical letters with a single one. 
//Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".

class Program
{
    static void Main()
    {
        string input = "Example: aaaaabbbbbcdddeeeedssaa , dASDAAA, Ddssfs";

        Console.WriteLine(Regex.Replace(input, @"(\w)\1+", "$1"));

        //Second Method

        StringBuilder build = new StringBuilder();

        build.Append(input[0]);
        for (int i = 1; i < input.Length; i++)
        {
            while (input[i - 1] == input[i])
            {
                i++;
            }
            build.Append(input[i]);
        }


        Console.WriteLine(build.ToString());
    }
}


