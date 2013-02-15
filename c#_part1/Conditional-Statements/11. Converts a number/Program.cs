using System;

class Program
{
    static string[] arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", 
                              "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen", 
                              "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety", "hundred" };
    static void Main(string[] args)
    {
        ushort number;
        string answer;
        while (true)
        {
            bool isNum = ushort.TryParse(Console.ReadLine(), out number);
            if (isNum)
            {
                if (number > 99 && number < 1000)
                {
                    if ((double)number / (number % 1000 / 100) == 100)
                    {
                        answer = arr[number % 1000 / 100] + " " + arr[arr.Length - 1];
                    }
                    else 
                    {   
                        answer = arr[number % 1000 / 100] + " " + arr[arr.Length - 1] + " " + (number % 100 / 10 == 0 ? "and" + " " + arr[number % 10] : (number % 100 < 21 ? "and " + arr[(number % 100)] : "and " + arr[18 + (number % 100 / 10)] + " " + (number % 10 != 0 ? arr[number % 10] : " ")));
                    }

                }
                else if (number < 100)
                {
                    if (number % 100 / 10 == 0)
                    {
                        answer = arr[number % 10];
                    }
                    else if (number < 21)
                    {
                        answer = arr[number];
                    } 
                    else 
                    {
                        answer = arr[18 + (number % 100 / 10)] + " " + (number % 10 != 0 ? arr[number % 10] : " ");
                    }

                }
                else
                {
                    continue;
                    //Console.WriteLine("[1-999]");
                }           
            Console.WriteLine(answer.Substring(0, 1).ToUpper() + answer.Substring(1));

            }
            else
            {
                Console.WriteLine("Number [1-999]");
            }
        }

    }
}
