using System;

namespace _9.Subset
{
    class Program
    {
        // We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0. 
        // Example: 3, -2, 1, 1, 8  1+1-2=0.

        public static int GetBit(int number, int posittion)
        {
            return (number & (1 << posittion)) >> posittion; // return the bit at "posittion"
        }

        static void Main(string[] args)
        {
            int[] numbers = { 5,-3, 4 ,-2 ,3, -2, 1, 1, 8 };
            int bit;

            double allSubsets = Math.Pow(2,numbers.Length); // will use a as binary number

            for (int i = 1; i < allSubsets ; i++)
            {
                int sum = 0;

                for (int k = 0; k < numbers.Length; k++) // do the subset sum
                {
                    bit = GetBit(number: i, posittion: k);
                    sum += numbers[k] * bit; 
                      
                }
                
                if (sum == 0)   // Print a Solution
                { 
                    for (int k = 0; k < numbers.Length; k++) 
                    {
                        bit = GetBit(number: i, posittion: k);
                        if (bit == 1)
                        {
                            Console.Write( numbers[k] < 0 ? "" + numbers[k] : "+" +  numbers[k]);
                        }
                        
                    }
                    Console.WriteLine(" = 0");
                }
            }

        }
    }
}
