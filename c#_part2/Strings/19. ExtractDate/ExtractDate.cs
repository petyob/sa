using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;

class ExtractDates
{
    static void Main(string[] args)
    {
        string text = @"dfds 11.11.2011 SDCS SOME TEXT 01.01.2001 test ТЕСТ";

        Regex date = new Regex("([1-9]|[12][0-9]|3[01]).([1-9]|0[1-9]|1[012]).([0-9][0-9][0-9])?[0-9]");

        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");

        foreach (Match dates in date.Matches(text))
        {
            Console.WriteLine(dates);
        }
    }
}

