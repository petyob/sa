using System;
using System.Text.RegularExpressions;
using System.Linq;

//Write a program that extracts from a given text all sentences containing given word.

class Program
{
    static void Main()
    {
        string givenText = @"We are living in a yellow submarine. We don't have anything else. 
            Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string givenWord = "in";

        Regex regEx = new Regex(@"\s*([^\.]*\s" + givenWord + @"\s.*?\.)");

        foreach (Match item in regEx.Matches(givenText))
        {
            Console.WriteLine(item.Groups[1]);
        }

        Console.WriteLine("Second Method:");

        string[] sentences = GetSentences(givenText);
        foreach (var sentence in sentences)
        {
            string[] words = GetWords(sentence);
            if (words.Contains(givenWord) == true)
            {
                Console.WriteLine(sentence.TrimStart() + ".");
            }
        }

    }

    static string[] GetSentences(string text)
    {
        return text.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
    }

    static string[] GetWords(string sentence)
    {
        return sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    }

}

