using System;

namespace _5.Name_of_the_digit
{
    class Program
    {
        // program that asks for a digit and depending on the input shows the name of that digit (in English) using a switch statement.

        static void Main(string[] args)
        {
            char aDigit = (char)Console.Read();

            switch (aDigit)
            {
                case '0': Console.WriteLine("zero"); break;
                case '1': Console.WriteLine("one"); break;
                case '2': Console.WriteLine("two"); break;
                case '3': Console.WriteLine("three"); break;
                case '4': Console.WriteLine("four"); break;
                case '5': Console.WriteLine("five"); break;
                case '6': Console.WriteLine("six"); break;
                case '7': Console.WriteLine("seven"); break;
                case '8': Console.WriteLine("eiht"); break;
                case '9': Console.WriteLine("nine"); break;
                default: Console.WriteLine("Not a digit"); break;
            }
           
        }
    }
}
