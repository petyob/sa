using System;
using System.Text;
//Write a program that converts a string to a sequence of C# Unicode character literals.
//Use format strings. Sample input:

class Program
{
    static void Main()
    {
        //string text = "Hi!♣";
        string text = Console.ReadLine();
        Console.WriteLine(ConvertToUtf32(text));
    }

    static string ConvertToUtf32(string s)
    {
        if (s == null)
        {
            throw new ArgumentNullException("s");
        }

        StringBuilder utf32 = new StringBuilder(s.Length * 6);

        for (int i = 0; i < s.Length; i++)
        {
            utf32.AppendFormat("\\u{0:X4}", (ushort)s[i]);
        }
        return utf32.ToString();
    }
}