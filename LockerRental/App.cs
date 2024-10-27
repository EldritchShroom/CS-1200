using LockerRental.Actions;

namespace LockerRental.Workflows
{
    public static class App
    {
        public static void Run()
        {
            LockerManager lockerManager = new LockerManager();

            while (true)
            {
                int choice = ConsoleIO.GetMenuOption();

                if (choice == 5)
                {
                    return;
                }
                else if (choice == 4)
                {
                    lockerManager.ListContents();
                }
                else
                {
                    int lockerNumber = ConsoleIO.GetLockerNumber();

                    if (choice == 1)
                    {
                        lockerManager.ViewLocker(lockerNumber);
                    }
                    else if (choice == 2)
                    {
                        lockerManager.RentLocker(lockerNumber);
                    }
                    else
                    {
                        lockerManager.EndRental(lockerNumber);
                    }
                }

                ConsoleIO.AnyKey();
            }
        }
    }
}