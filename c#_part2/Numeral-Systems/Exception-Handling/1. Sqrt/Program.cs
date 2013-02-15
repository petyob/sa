using System;

class Program
//Write a program that reads an integer number and calculates and prints its square root. 
//If the number is invalid or negative, print "Invalid number". 
//In all cases finally print "Good bye". Use try-catch-finally
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Integer number: ");
            try
            {
                int number = int.Parse(Console.ReadLine());

                if (number < 0)
                {
                    throw new ArgumentException();
                }

                double squareRoot = Math.Sqrt(number);
                Console.WriteLine("Square root of {0} is {1}.", number, squareRoot);
            }

            catch (OverflowException message)
            {
                Console.WriteLine("Value was either too large or too small!\n" + message);
            }
            catch (ArgumentNullException message) // Catch - ^Z
            {
                Console.WriteLine("No input!\n" + message);
            }
            catch (ArgumentException message) 
            {
                Console.WriteLine("Invalid number! The square root is defined only for non-negative numbers!\n" + message);
            }
            catch (FormatException message)
            {
                Console.WriteLine("Invalid integer number!\n" + message);
            }
            catch (Exception message) 
            {
                Console.WriteLine(message);
            }
            finally
            {
                Console.WriteLine("Goodbye!");
            }
        }       
    }
}

