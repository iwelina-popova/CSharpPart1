/* A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
Write a program that reads the information about a company and its manager and prints it back on the console.
Example input:

program	            user

Company name:	    Telerik Academy
Company address:	31 Al. Malinov, Sofia
Phone number:	    +359 888 55 55 555
Fax number:	        2
Web site:	        http://telerikacademy.com/
Manager first name:	Nikolay
Manager last name:	Kostov
Manager age:	    25
Manager phone:	    +359 2 981 981
  
Example output:

Telerik Academy
Address: 231 Al. Malinov, Sofia
Tel. +359 888 55 55 555
Fax: (no fax)
Web site: http://telerikacademy.com/
Manager: Nikolay Kostov (age: 25, tel. +359 2 981 981)    */

using System;

    class CompanyInformation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Please enter information about a company.");
            Console.Write("Company name: ");
            string companyName = Console.ReadLine();
            Console.Write("Company address: ");
            string companyAddress = Console.ReadLine();
            Console.Write("Phone Number (example: +359 888 55 55 555): ");
            string phoneNumber = Console.ReadLine();
            Console.Write("Fax number (example: +1-212-9876543): ");
            string faxNumber = Console.ReadLine();
            Console.Write("Web site (example: http://telerikacademy.com/): ");
            string webSite = Console.ReadLine();
            Console.Write("Manager first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Manager last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Manager age: ");
            int age = int.Parse(Console.ReadLine());                       
            Console.Write("Manager phone (example: +359 2 981 981): ");
            string managerPhone = Console.ReadLine();

            Console.WriteLine("\n\n============Your Information============\n");
            Console.WriteLine(companyName + "\nAddress: {0}\nTel. {1}\nFax: {2}\nWeb site: {3}", companyAddress, phoneNumber, faxNumber, webSite);
            Console.WriteLine("Manager {0} {1} (age: {2}, tel. {3})", firstName, lastName, age, managerPhone);

            Console.ReadLine();
        }
    }

