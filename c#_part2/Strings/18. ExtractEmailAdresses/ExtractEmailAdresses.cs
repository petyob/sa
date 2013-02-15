using System;
using System.Text.RegularExpressions;
//Write a program for extracting all email addresses from given text.
//All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.

class Program
{
    static void Main()
    {
        string email = "sdva afa sad f aaaa@dsfa.sdf.sdf.com DFCDC df test@dir.bg sdfafssda ";
        string emailPattern = @"(\w+@[a-zA-Z0-9_\-\.]+\.\w+)";
        //string emailPattern = @"[a-zA-Z0-9_\-\.]+@[a-zA-Z0-9_\-\.]+\.[a-zA-Z]{2,5}";
       
        Regex regEx = new Regex(emailPattern);

        foreach (Match item in regEx.Matches(email))
        {
            Console.WriteLine(item);
        }

    }
}

