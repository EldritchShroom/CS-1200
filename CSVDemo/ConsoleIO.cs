namespace CSVDemo;

public static class ConsoleIO
{
    public static int DisplayMenu()
    {
        int choice;

        do
        {
            Console.WriteLine("Event Calendar");
            Console.WriteLine("1. View all events");
            Console.WriteLine("2. Add an Event");
            Console.WriteLine("3. Exit\n");
            Console.Write("Enter your choice: ");

            string input = Console.ReadLine();

            if (int.TryParse(input, out choice))
            {
                if(choice >= 1 && choice <=3)
                {
                    return choice;
                }
            }

            Console.WriteLine("Invalid choice. Please try again.")
            Console.WriteLine();
        } while (true);
    }

    public static Event CreateEvent()
    {
        Console.WriteLine("Create a new event: ");

        Event newEvent = new Event();

        newEvent.Title = GetRequireString("Enter the event title: ");
        newEvent.Description = GetRequiredString("Enter the event description: ");
        newEvent.EventDate = GetFutureDate("Enter the event date (YYYY-MM-DD): ");
        newEvent.time = GetTime("Enter the event time (HH:MM:SS): ");

        return newEvent;
    }

    public static void DisplayEvent(Event e)
    {
        Console.WriteLine("===========================================");
        Console.WriteLine($"Date: {e.EventDate}");
        Console.WriteLine($"Time: {e.Time}");
        Console.WriteLine($"Title: {e.Title}");
        Console.WriteLine($"Description: {e.Description}");
        Console.WriteLine("===========================================");

    }

    public static void AnyKey()
    {
        Console.Write("Press any key to continue...");
        Console.ReadKey();
    }

    public static string GetRequiredString(string prompt);
    {
        string input; 
        
        while (true)
        {
            Console.Write(prompt);
            input = Console.readLine();

            if (!string.IsNullOrWhiteSpace(input))
            {
                return input;
            }

            Console.WriteLine("Input cannot be empty. Please try again.");
            Console.WriteLine();
        }
    }

    private static DateOnly GetFutureDate(string prompt)
    {
        while(true)
        {
            Console.Write(prompt);
            input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input))
            {
                return input;            
            }
            Console.WriteLine("Input cannot be empty. Please try again.");
            Console.WriteLine();
            
        }
    }
}