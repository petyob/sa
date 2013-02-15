using System;
using System.Collections.Generic;
//Write a program that reads a string from the console and prints all different letters
//in the string along with information how many times each letter is found. 

class CountLetters
{
    static void Main()
    {
        string input = "СДФАСДФА Write a program that reads a string from the console and prints all different letters";

        Dictionary<char, int> letters = new Dictionary<char, int>();

        foreach (char item in input)
        {
            if (Char.IsLetter(item))
            {
                if (!letters.ContainsKey(item))
                {
                    letters.Add(item, 0);
                }
                letters[item]++;
            }
        }
        
        foreach (var item in letters)
        {
            Console.WriteLine("{0} - {1}", item.Key,item.Value);
        }
    }
}

