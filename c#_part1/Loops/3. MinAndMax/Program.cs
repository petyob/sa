using System;

namespace _3.MinAndMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()),
                number;

            int min = Int32.MaxValue,
                max = Int32.MinValue;

            for (int i = 0; i < n; i++)
            {
                number = Convert.ToInt32(Console.ReadLine());
                
                if (min > number)
                {
                    min = number;
                }

                if (max < number)
	            {
                    max = number;
		 
	            }
           }
            Console.WriteLine(min +"," + max);
                


        }
    }
}
