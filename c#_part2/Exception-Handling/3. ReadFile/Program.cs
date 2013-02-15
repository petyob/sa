using System;
using System.IO;


class Program
//Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini),
//reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…).
//Be sure to catch all possible exceptions and print user-friendly error messages.
{
    static void Main()
    {
        string path; // = @"C:\WINDOWS\win.ini";
        path = Console.ReadLine();

        try
        {
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("File name and path are missing(path is null).");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Invalid file name or path. path is a zero-length string, contains only white space, or contains one or more invalid characters as defined by ");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. ");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Directory not found. Path refers to a location that is unavailable.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found. Make sure you typed the name correctly.");
        }
        catch (IOException)
        {
            Console.WriteLine("An I/O error occurred while opening the file.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Access is denied.");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Path is in an invalid format.");
        }

    }
}

