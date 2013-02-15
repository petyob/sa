using System;
using System.Collections.Generic;
using System.Text;
//A dictionary is stored as a sequence of text lines containing words and their explanations.
//Write a program that enters a word and translates it by using the dictionary. Sample dictionary:

class Program
{
    static void Main(string[] args)
    {
        string text = @".NET – platform for applications from Microsoft
                        CLR – managed execution environment for .NET
                        namespace – hierarchical organization of classes";
        string word = "CLR";

        Dictionary<string, string> dict = new Dictionary<string, string>();

        MakeDict(text, dict);

        string meaning;
        if (dict.TryGetValue(word, out meaning))
        {
            Console.WriteLine("Meaning - " + meaning);
        }
        else
        {
            Console.WriteLine("Not found!");
        }
    }

    private static void MakeDict(string text, Dictionary<string, string> dict)
    {
        string[] lines = text.Split('\n');

        foreach (var line in lines)
        {
            string[] temp = line.Split(new char[] { '–' }, 2);
            dict.Add(temp[0].Trim(), temp[1].Trim());
        }
    }
}

