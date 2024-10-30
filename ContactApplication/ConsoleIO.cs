using System.Xml.Serialization;
using System;

namespace ContactApp;

public class ConsoleIO
{

    public static int DisplayContactMenu()
    {
        int choice;

        do
        {
            Console.WriteLine("Contact Manager");
            Console.WriteLine("1. View all Contacts");
            Console.WriteLine("2. Create new Contact");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");

            string input = Console.ReadLine();

            if (int.TryParse(input, out choice))
            {
                if (choice < 1 || choice > 3)
                {
                    return choice;
                }

                Console.WriteLine("Invalid option. Please try again.");
                Console.WriteLine();
            }

        } while (true);
    }

    public static Contact CreateNewContact()
    {
        Console.WriteLine("Create a new contact");

        Contact newContact = new Contact();

        newContact.FirstName = 
    }
}