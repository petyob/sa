using System;

//Read your age from the console and print how old you will be after 10 years.
class Age
{
    static void Main()
    {
        byte currentAge;
        while (true)
        {
            Console.Write("Please enter your age: ");
            if (byte.TryParse(Console.ReadLine(), out currentAge))
            {
                Console.WriteLine("You will be {0} years old after 10 years", currentAge + 10);
                break;
            }
        }
    }
}

