using System;
using System.Text;

//We are given a string containing a list of forbidden words and a text containing some of these words. 
//Write a program that replaces the forbidden words with asterisks. Example:

class Program
{
    static void Main()
    {
        string givenText = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        string wordsToRaplace = "PHP, CLR, Microsoft";

        string[] words = wordsToRaplace.Split(new char[] { ',' });

        StringBuilder strBuild = new StringBuilder(givenText);

        foreach (var word in words)
        {
            string aWord = word.Trim();
            string mask = new string('*', aWord.Length);
            strBuild.Replace(aWord, mask);
        }
        Console.WriteLine(strBuild);
    }
}


