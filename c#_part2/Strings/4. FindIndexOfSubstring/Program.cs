using System;
//Write a program that finds how many times a substring 
//is contained in a given text (perform case insensitive search).
//Example: The target substring is "in". The text is as follows:
//"We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days."
//	The result is: 9.

class Program
{
    static void Main()
    {
        string text = @"We are living in an yellow submarine. We don't have anything else. 
Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";

        Console.WriteLine(CountStringIndex(text));
    }
    private static int CountStringIndex(string text)
    {
        text = text.ToLower();
        int counter = 0;
        int index = 0;

        do
        {
            int test = (text.IndexOf("in", index));
            if (!(test == -1))
            {
                counter++;
                index = test+2;
            }
            else
            {
                break;
            }
        } while (index < text.Length);
        return counter;
    }
}

