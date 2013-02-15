﻿using System;

class Program
//Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
//If an invalid number or non-number text is entered, the method should throw an exception.
//Using this method write a program that enters 10 numbers:
//	a1, a2, … a10, such that 1 < a1 < … < a10 < 100
{
    static void Main()
    {
        int start = 1, end = 100;

        Console.WriteLine("Enter 10 numbers is [1,100]");

        for (int i = 0; i < 10; i++)
        {
            Console.Write("a" + i + "= ");
            try
            {   

                ReadNumber(start, end);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid number -> (n < start) || (n > end)");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Value cannot be null");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid number -> (n < start) || (n > end)");
            }
            catch (Exception)
            {
                Console.WriteLine("Unexpected error!");
            }
        }
    }

    /// <summary>
    ///  method ReadNumber(int start, int end) that enters an integer number in given range [start…end].
    /// </summary>
    static int ReadNumber(int start, int end)
    {
        int n;

        n = int.Parse(Console.ReadLine());
        if ((n < start) || (n > end))
        {
            throw new ArgumentOutOfRangeException();
        }
        return n;
    }

}

