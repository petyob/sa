using System;
//Write a program that reads from the console a string of maximum 20 characters.
//If the length of the string is less than 20, the rest of the characters should be filled with '*'. 
//Print the result string into the console.

class Program
{
    static void Main()
    {
        string inputString = Console.ReadLine();
        Console.WriteLine(inputString.PadRight(20, '*'));
    }
}

