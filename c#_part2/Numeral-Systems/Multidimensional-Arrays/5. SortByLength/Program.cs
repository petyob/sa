using System;

class Program
// You are given an array of strings.
//Write a method that sorts the array by the length of its elements (the number of characters composing them).
{
    static void Main()
    {
        string[] strArray = { "asd", "EW", "sdf", "", "fdsafwsef", "fsdafsd", "dsafs" };

        Array.Sort(strArray, (x, y) => (x.Length).CompareTo(y.Length));

        foreach (var item in strArray)
        {
            Console.WriteLine(item);
        }
    }
}

