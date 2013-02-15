using System;
using System.Globalization;

//Write a program that reads a date and time given in the format:
//day.month.year hour:minute:second and prints the date and time
//after 6 hours and 30 minutes (in the same format)
//along with the day of week in Bulgarian.

class Program
{
    static void Main()
    {
        string DateString = "27.02.2006 18:13:52";

        //string DateString = Console.ReadLine();

        try
        {
            DateTime date = DateTime.ParseExact(DateString, "d.MM.yyyy H:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(date);
            Console.WriteLine("After 6 hours and 30 minutes : " + date.AddHours(6).AddMinutes(30));
        }
        catch (FormatException)
        {

            Console.WriteLine("The Date is Not in format ");
        }
    }
}