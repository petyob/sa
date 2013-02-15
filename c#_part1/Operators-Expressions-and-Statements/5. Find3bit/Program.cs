using System;


// boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.
class Program
{
    static void Main(string[] args)
    {
    
        int mask = 1 << 3;  // 1000

        int number;
            
        bool isNumber = int.TryParse(Console.ReadLine(), out number);
        int i = number & mask;
        if (isNumber)
        {
            if ((number & mask) > 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
        else
        {
            Console.WriteLine("Integer number requared!");
        }
    }
        
}

