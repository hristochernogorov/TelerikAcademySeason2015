//Problem 2: A company has name, address, phone number, fax number, web site and manager. 
//The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.

using System;
using System.Globalization;
using System.Threading;

class PrintCompanyInformation
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("This program print of the console some Company information.");
        Console.WriteLine("Please enter Company name:");
        string companyName = Console.ReadLine();
        Console.WriteLine("Please enter Company address:");
        string companyAddress = Console.ReadLine();
        Console.WriteLine("Please enter phone number:");
        string phoneNumber =(Console.ReadLine());
        Console.WriteLine("Please enter fax number:");
        string faxNumber =(Console.ReadLine());
        Console.WriteLine("Please enter the web site of company:");
        string webSite = Console.ReadLine();
        Console.WriteLine("Please enter the first name of Manager:");
        string firstNameManager = Console.ReadLine();
        Console.WriteLine("Please enter the last name of Manager:");
        string lastNameManager = Console.ReadLine();
        Console.WriteLine("Please enter age of Manager:");
        byte ageManager = byte.Parse(Console.ReadLine());
        Console.WriteLine("Please enter phone number of Manager:");
        string phoneManager =(Console.ReadLine());
        Console.WriteLine("-".PadLeft(80, '-'));
        Console.WriteLine("-".PadLeft(80, '-'));
        Console.WriteLine("-".PadLeft(80, '-'));
        //Here write result.
        string formattedText = "{0,-20} - {1}";
        Console.WriteLine(formattedText, "Company name:", companyName);
        Console.WriteLine(formattedText, "Company address is:", companyAddress);
        Console.WriteLine(formattedText, "Phone number is:", phoneNumber);
        Console.WriteLine(formattedText, "Fax number is:", faxNumber);
        Console.WriteLine(formattedText, "Web site:", webSite);
        Console.WriteLine(formattedText, "Manager first name:", firstNameManager);
        Console.WriteLine(formattedText, "Manager last name:", lastNameManager);
        Console.WriteLine(formattedText, "Manager age:", ageManager);
        Console.WriteLine(formattedText, "Manager phone:", phoneManager);

    }
}

