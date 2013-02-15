using System;


class Program
//Write a program that generates and prints to the console 10 random values in the range [100, 200].
{
    static Random random = new Random();
    static void Main()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(random.Next(100,201)); // Integer - [100,200] = [100,201)
        }
    }
}

