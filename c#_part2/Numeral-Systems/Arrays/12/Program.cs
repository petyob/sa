using System;

class Program
//Creates an array containing all letters from the alphabet (A-Z). 
//Read a word from the console and print the index of each of its letters in the array.
{
    static void Main()
    {
        char[] chars = new char[26];

        for (int i = 0; i < 26; i++)
        {
            chars[i] = (char)('A' + i);
        }

        //for (int i = 0; i < 26; i++)
        //{
        //    Console.WriteLine(chars[i]);
        //}

        string aWord = (Console.ReadLine());

        for (int i = 0; i < aWord.Length; i++)
        {
            Console.WriteLine(Array.BinarySearch(chars,aWord[i]));
        }

    }
}

