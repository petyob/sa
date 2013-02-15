using System;


class Program
//Write a program that reads a year from the console and checks whether it is a leap.
//Use DateTime.
{
    static void Main()
    {

        while (true)
        {
            int year = int.Parse(Console.ReadLine());

            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("leap");
            }
            else
            {
                Console.WriteLine("not leap");

            }

        }

    }
}

