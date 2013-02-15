using System;
using System.Text.RegularExpressions;
//You are given a text. Write a program that changes the text in all regions
//surrounded by the tags <upcase> and </upcase> to uppercase. The tags cannot be nested. 
class Program
{
    static void Main()
    {
        string givenText = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        Regex regEx = new Regex("<upcase>(.*?)</upcase>");

        Console.WriteLine(regEx.Replace(givenText, new MatchEvaluator(UpText)));

        // Second Method with Lambda:
        Console.WriteLine(regEx.Replace(givenText, matches => matches.Groups[1].Value.ToUpper()));

        // 3 Method
        Console.WriteLine(regEx.Replace(givenText, delegate(Match matches) { return matches.Groups[1].Value.ToUpper(); }));

    }

    static string UpText(Match matches)
    {
        return matches.Groups[1].Value.ToUpper();
    }
}

