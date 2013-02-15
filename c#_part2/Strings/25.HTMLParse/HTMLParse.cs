using System;
using System.IO;

// Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags. 
//Example:
// <html>
//  <head><title>News</title></head>
//  <body><p> <a href="http://academy.telerik.com">Telerik
//    Academy</a>aims to provide free real-world practical
//    training for young people who want to turn into
//    skillful .NET software engineers.
//  </p></body>
// </html>

class HTMLParse
{
    static void Main()
    {
        string input;
        using (StreamReader reader = new StreamReader("../../HTMLPage1.html"))
        {
            input = reader.ReadToEnd();
        }

        string outText = ExtractText(input);

        Console.WriteLine(outText);
    }

    private static string ExtractText(string html)
    {

        int beginTag = html.IndexOf('<');
        int endTag = html.IndexOf('>');
        while (beginTag >= 0)
        {
            if (beginTag >= endTag)
            {
                throw new FormatException("Invalid HTML format");
            }

            html = html.Remove(beginTag, endTag - beginTag + 1); // Remove tag

            beginTag = html.IndexOf('<');
            endTag = html.IndexOf('>');
        }
        return html;
    }
}


