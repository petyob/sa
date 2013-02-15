using System;
using System.Text;
//Write a program that reads a string, reverses it and prints the result at the console.
// Example: "sample"  "elpmas".

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            string aString = Console.ReadLine();
            try
            {
                char[] reverseString = ReverseString(aString);

                Console.WriteLine(reverseString);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("String is missing!(null)");
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("String is too big to feed in memory!!");
            }
        }
    }

    private static char[] ReverseString(string aString)
    {
        if (aString == null)
        {
            throw new NullReferenceException();
        }
        char[] reverseString = aString.ToCharArray();
  
        Array.Reverse(reverseString);

        return reverseString;
    }

    //Second Method
    //private static string ReverseString2(string aString)
    //{
    //    if (aString == null)
    //    {
    //        throw new NullReferenceException();
    //    }
    //    int length = aString.Length;
    //    StringBuilder reverseString = new StringBuilder(length);
    //    for (int i = length - 1; i >= 0; i--)
    //    {
    //        reverseString.Append(aString[i]);
    //    }
    //    return reverseString.ToString();
    //}
}

