using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

//Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

class ExtractPalindromes
{
    static void Main()
    {
        string text = "Write aha a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe. ";
        char[] separators = { ' ', ',', ';', ':' ,'.' };

        string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        foreach (var word in words)
        {
            if (word.Length == 1)
            {
                continue;
            }
            if (isPalindromes(word))
            {
                Console.WriteLine(word);
            }
        }

    }

    private static bool isPalindromes(string word)
    {
        bool isPalind = true;

        for (int i = 0; i < word.Length/2; i++)
        {
            if (word[i] != word[word.Length-i-1])
            {
                isPalind = false;
                break;
            }
        }

        return isPalind;
    }
}

