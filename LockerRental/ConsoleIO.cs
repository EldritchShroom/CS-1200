using LockerRental.DTOs;

namespace LockerRental.Actions
{
    public static class ConsoleIO
    {
        public static string GetRequiredString(string prompt)
        {
            string input;
            do
            {
                Console.Write(prompt);
                input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input)) break;
                Console.WriteLine("Input cannot be empty.");
            } while (true);

            return input;
        }

        public static void DisplayLockerContents(LockerContents dto, int lockerNumber)
        {
            if (dto != null)
            {
                Console.WriteLine($"Locker {lockerNumber}: {dto.Description}");
            }
            else
            {
                Console.WriteLine($"Locker {lockerNumber} is EMPTY.");
            }
        }

        public static int GetLockerNumber()
        {
            int lockerNumber;
            do
            {
                Console.Write("Enter locker number (1-100): ");
            } while (!int.TryParse(Console.ReadLine(), out lockerNumber) || lockerNumber < 1 || lockerNumber > 100);

            return lockerNumber;
        }

        public static int GetMenuOption()
        {
            int choice;
            do
            {
                Console.WriteLine("\nLocker Rental Menu");
                Console.WriteLine("1. View a locker");
                Console.WriteLine("2. Rent a locker");
                Console.WriteLine("3. End a locker rental");
                Console.WriteLine("4. List all locker contents");
                Console.WriteLine("5. Quit");
                Console.Write("Enter your choice (1-5): ");
            } while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5);

            return choice;
        }

        public static void AnyKey()
        {
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}