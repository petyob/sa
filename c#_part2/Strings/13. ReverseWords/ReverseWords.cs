using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        string str = "C# is not C++, not PHP and not Delphi!";

        char[] separators = { ' ', ',', '!', '?', '.' };
        char[] letters = GetAllLetters();

        List<string> words = new List<string>();
        List<string> noWords = new List<string>();

        foreach (var word in str.Split(separators, StringSplitOptions.RemoveEmptyEntries))
        {
            words.Add(word);
        }

        foreach (var sign in str.Split(letters, StringSplitOptions.RemoveEmptyEntries))
        {
            noWords.Add(sign);
        }

        StringBuilder build = new StringBuilder();
        for (int i = 0; i < words.Count; i++)
        {
            build.Append(words[words.Count - i - 1]).Append(noWords[i]);
        }

        Console.WriteLine(build);
    }

    private static char[] GetAllLetters()
    {
        List<char> letters = new List<char>();

        for (char i = 'a'; i <= 'z'; i++)
        {
            letters.Add(i);
        }
        for (char i = 'A'; i <= 'Z'; i++)
        {
            letters.Add(i);
        }

        letters.Add('+');
        letters.Add('#');
        return letters.ToArray();
    }
}