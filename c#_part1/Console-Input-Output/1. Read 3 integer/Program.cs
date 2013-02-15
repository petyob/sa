using System;


namespace _1.Read_3_integer
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            bool isCorrect;

            Console.Write("a = ");
            string input = Console.ReadLine();

            isCorrect = int.TryParse(input, out a);

            Console.Write("b = ");
            input = Console.ReadLine();

            isCorrect = int.TryParse(input, out b) && isCorrect;

            Console.Write("c = ");
            input = Console.ReadLine();

            isCorrect = int.TryParse(input, out c) && isCorrect;

            if (!isCorrect)
            {
                Console.WriteLine("Not integer!");
            }
            else
            {
                Console.WriteLine("Sum = " + (a + b + c));
            }


        }
    }
}
