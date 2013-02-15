using System;
using System.Globalization;

//Write a program that reads two dates in the format: 
//day.month.year and calculates the number of days between them.
//Example:
//Enter the first date: 27.02.2006
//Enter the second date: 3.03.2004
// Distance: 4 days

class Program
{
    static void Main()
    {
        //string firstDateString = "27.02.2006";
        //string secondDateString = "3.03.2004"; 

        string firstDateString = Console.ReadLine();
        string secondDateString = Console.ReadLine();

        try
        {
            DateTime firstDate, secondDate;

            firstDate = DateTime.ParseExact(firstDateString, "d.MM.yyyy", CultureInfo.InvariantCulture);
            secondDate = DateTime.ParseExact(secondDateString, "d.MM.yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(Math.Abs((secondDate - firstDate).TotalDays));
        }
        catch (FormatException)
        {

            Console.WriteLine("The Date is Not in format d.MM.yyyy");
        }

    }
}