using System;

namespace _10.Bonus_scores
{
    class Program
    {
        static void Main(string[] args)
        {
            string  digit = Console.ReadLine();
            
            switch (digit)
            {
                
                case "0": Console.WriteLine( "Error O" ); break;
                case "1":
                case "2":
                case "3": Console.WriteLine( (Convert.ToInt32(digit) * 10 )); break;
                case "4":
                case "5":
                case "6": Console.WriteLine( (Convert.ToInt32(digit) * 100 )); break;
                case "7":
                case "8":
                case "9": Console.WriteLine( (Convert.ToInt32(digit) * 1000 )); break;

                default: Console.WriteLine("Not a digit"); break;


            }
        }
    }
}
