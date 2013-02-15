using System;
using System.IO;

//Write a program that reads a text file and prints on the console its odd lines.

class OddLines
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader(@"..\..\text.txt"))
        {
            int counterOfLine = 1;
            string line = reader.ReadLine();
            
            while (line != null)
            {
                if ((counterOfLine & 1) == 1)
                {
                    Console.WriteLine(line);
                }
                line = reader.ReadLine();
                counterOfLine++;
            }
        }
    }
}

