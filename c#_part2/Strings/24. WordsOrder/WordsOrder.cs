using System;
//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
class Program
{
    static void Main()
    {
        string input = "Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order";

        string[] words = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

        Array.Sort(words);

        foreach (var item in words)
        {
            Console.WriteLine(item);
        }
    }
}
