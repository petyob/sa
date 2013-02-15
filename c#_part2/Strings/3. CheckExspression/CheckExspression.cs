using System;
using System.Text.RegularExpressions;
//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d).
//Example of incorrect expression: )(a+b)).
class Program
{
    static void Main(string[] args)
    {
        string expression = ")((a+b/5-d)";
        Console.WriteLine(IsCorrect(expression));
    }

    private static bool IsCorrect(string expression)
    {
        int countBrackets = 0;
        
        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i] == '(')
            {
                countBrackets++;
            }
            else if (expression[i] == ')')
            {
                countBrackets--;
            }

            if (countBrackets < 0)
            {
                return false;
            }
        }

        if (!(countBrackets == 0))
        {
            return false;
        }
        return true;
    }
}

