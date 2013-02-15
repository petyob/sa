using System;
// Write a program that reads a number and prints it as a decimal number, 
//hexadecimal number, percentage and in scientific notation. 
//Format the output aligned right in 15 symbols.

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        //string number = Console.ReadLine();

        Console.WriteLine("{0,15:D} - decimal.", number);
        Console.WriteLine("{0,15:X} - hexadecimal.",  number);
        Console.WriteLine("{0,15:P} - percentage.", number);
        Console.WriteLine("{0,15:E} - scientific notation.", number);
    }
}

