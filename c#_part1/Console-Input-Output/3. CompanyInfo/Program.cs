using System;

namespace _3.CompanyInfo
{
    class Program
    {
        // A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number. Write a program that reads the information about a company and its manager and prints them on the console.

        static void Main(string[] args)
        {
            string companyName, companyAddress;
            string companyPhoneNumber, companyFaxNumber;
            string companyWebsite;
            string managerFirstName, managerLastName, managerPhoneNumber;
            byte managerAge;

            Console.Write("company's name: ");
            companyName = Console.ReadLine();

            Console.Write("company's address: ");
            companyAddress = Console.ReadLine();

            Console.Write("company's phone number: ");
            companyPhoneNumber = Console.ReadLine();

            Console.Write("company's fax number: ");
            companyFaxNumber = Console.ReadLine();

            Console.Write("company's website: ");
            companyWebsite = Console.ReadLine();

            Console.Write("manager's first name: ");
            managerFirstName = Console.ReadLine();

            Console.Write("manager's last name: ");
            managerLastName = Console.ReadLine();

            Console.Write("manager's phone number: ");
            managerPhoneNumber = Console.ReadLine();

            Console.Write("manager's age: ");
            managerAge = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("The company's info\n Name: {0}\n Address: {1}\n Phone number: {2}\n Fax number: {3}\n Website: {4}", companyName, companyAddress, companyPhoneNumber, companyFaxNumber, companyWebsite);
            Console.WriteLine("Manager's info\n Name: {0}\n Phone number: {1}\n Age: {2}", managerFirstName + " " + managerLastName, managerPhoneNumber, managerAge);
        }
    }
}
