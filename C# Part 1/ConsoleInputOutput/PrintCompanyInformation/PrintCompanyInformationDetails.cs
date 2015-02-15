//Problem 2. Print Company Information

//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.

using System;

class PrintCompanyInformationDetails
{
    static void Main()
    {
        Console.Write("Please enter company name: ");
        string companyName = (Console.ReadLine());
        Console.Write("Please enter company address: ");
        string companyAddress = (Console.ReadLine());
        Console.Write("Please enter company phone number: ");
        string companyPhoneNumber = (Console.ReadLine());
        Console.Write("Please enter company fax number: ");
        string faxNumber = (Console.ReadLine());
        Console.Write("Please enter company web site: ");
        string webSite = (Console.ReadLine());
        Console.Write("Please enter youre first name: ");
        string firstName = (Console.ReadLine());
        Console.Write("Please enter youre last name: ");
        string lastName = (Console.ReadLine());
        object fullName = firstName + " " +  lastName;
        Console.Write("Please enter youre age: ");
        sbyte managerAge = sbyte.Parse(Console.ReadLine());
        Console.Write("Please enter youre phone number: ");
        string managerPhoneNumber=(Console.ReadLine());
        Console.WriteLine(companyName);
        Console.WriteLine("Adress: " + companyAddress);
        Console.WriteLine("Tel. " + companyPhoneNumber);
        Console.WriteLine("Fax: " + faxNumber);
        Console.WriteLine("Web Site: " + webSite);
        Console.WriteLine("Manager: {0} (age: {1}, tel. {2})",fullName, managerAge, managerPhoneNumber);
        Console.WriteLine();
    }
}

