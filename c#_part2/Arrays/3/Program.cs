using System;

class Program
// Compares two char arrays lexicographically (letter by letter).
{
    static void Main()
    {
        Console.WriteLine("Compares two char arrays lexicographically (letter by letter)");

        // Reads two arrays from the console
        Console.Write("Enter 1-st array length: ");
        int n = int.Parse(Console.ReadLine());

        char[] arr1 = new char[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("arr1[{0}] = ", i);
            arr1[i] = char.Parse(Console.ReadLine());
        }

        Console.Write("Enter 2-nd array length: ");
        int m = int.Parse(Console.ReadLine());

        char[] arr2 = new char[m];

        for (int i = 0; i < m; i++)
        {
            Console.Write("arr2[{0}] = ", i);
            arr2[i] = char.Parse(Console.ReadLine());
        }

        // Compare arrays after constructing strings from these arrays.
        string charArray1ToString = new string(arr1);
        string charArray2ToString = new string(arr2);

        int compareAnswer = string.Compare(charArray1ToString, charArray2ToString);

        switch (compareAnswer)
        {
            case -1: 
                Console.WriteLine("arr1[] < arr2[]");
                break;
            case 1:
                Console.WriteLine("arr1[] > arr2[]");
                break;
            default:
                Console.WriteLine("arr1[] == arr2[]");
                break;
                       
        }
            
    }
}

