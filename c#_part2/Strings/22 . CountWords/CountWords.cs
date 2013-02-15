using System;
using System.Collections.Generic;
// Write a program that reads a string from the console and lists 
//all different words in the string along with information how many times each word is found.


class CountLetters
{
    static void Main()
    {
        string input = "Write from a program that is reads a string from the console and the lists all words different words in the string along with information how many times each word is found. ";

        Dictionary<string, int> words = new Dictionary<string, int>();
        char[] separators = new char[] { ' ', ',', ';', ':', '-','.' };

        string[] wordsArray = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        foreach (var item in wordsArray)
        {
            if (!words.ContainsKey(item))
            {
                words.Add(item, 0);
            }
            words[item]++;
        }

        foreach (var item in words)
        {
            Console.WriteLine("{0} - {1}", item.Key, item.Value);
        }
    }
}

