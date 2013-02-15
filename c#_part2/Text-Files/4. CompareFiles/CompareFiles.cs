using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

//Write a program that compares two text files line by line and prints the number of lines
//that are the same and the number of lines that are different. 
//Assume the files have equal number of lines.

class CompareFiles
{
    static void Main()
    {
        using (StreamReader readerFirstFile = new StreamReader("../../CompareFiles.cs"))
        {
            using (StreamReader readerSecondFile = new StreamReader("../../CompareFiles.cs"))
            {
                string firstLine = readerFirstFile.ReadLine();
                string secondLine = readerSecondFile.ReadLine();
                int counterSameLines = 0;
                int counterDifferentLines = 0;

                while (firstLine != null && secondLine != null)
                {
                    if (firstLine == secondLine)
                    {
                        counterSameLines++;
                    }
                    else
                    {
                        counterDifferentLines++;
                    }

                    firstLine = readerFirstFile.ReadLine();
                    secondLine = readerSecondFile.ReadLine();
                }

                Console.WriteLine(" same lines number: {0}\n different lines number: {1}", counterSameLines, counterDifferentLines);
            }

        }
    }
}

