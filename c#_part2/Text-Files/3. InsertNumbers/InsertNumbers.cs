using System;
using System.Text;
using System.IO;
//Write a program that reads a text file and inserts line numbers in front of each of its lines. 
//The result should be written to another text file.

class InsertNumbers
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader(@"..\..\InsertNumbers.cs"))
        {
            string line = reader.ReadLine();
            int counter = 1;
            StringBuilder text = new StringBuilder();
            while (line != null)
            {
                text.Append(String.Format("{0} {1}\r\n", counter, line));
                counter++;
                line = reader.ReadLine();
            }

            using (StreamWriter writer = new StreamWriter(@"..\..\output.txt"))
            {
                writer.Write(text.ToString());
                Console.WriteLine("write done.");
            }
        }
    }
}

