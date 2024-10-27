using LockerRental.DTOs;

namespace LockerRental.Actions
{
    public class LockerManager
    {
        private LockerContents[] _lockers = new LockerContents[100];

        public void ListContents()
        {
            for (int i = 0; i < _lockers.Length; i++)
            {
                if (_lockers[i] != null)
                {
                    ConsoleIO.DisplayLockerContents(_lockers[i], i + 1);
                }
            }
        }

        public void ViewLocker(int lockerNumber)
        {
            ConsoleIO.DisplayLockerContents(_lockers[lockerNumber - 1], lockerNumber);
        }

        public void RentLocker(int lockerNumber)
        {
            if (_lockers[lockerNumber - 1] != null)
            {
                Console.WriteLine($"Sorry, but locker {lockerNumber} has already been rented!");
            }
            else
            {
                var lockerContent = new LockerContents
                {
                    Description = ConsoleIO.GetRequiredString("Enter the item you want to store in the locker: "),
                    RenterName = ConsoleIO.GetRequiredString("Enter your full name: ")
                };
                _lockers[lockerNumber - 1] = lockerContent;
                Console.WriteLine($"Locker {lockerNumber} has been rented for {lockerContent.Description} storage.");
            }
        }

        public void EndRental(int lockerNumber)
        {
            if (_lockers[lockerNumber - 1] == null)
            {
                Console.WriteLine($"Locker {lockerNumber} is not currently rented.");
            }
            else
            {
                Console.WriteLine($"Locker {lockerNumber} rental has ended, please take your {_lockers[lockerNumber - 1].Description}.");
                _lockers[lockerNumber - 1] = null;
            }
        }
    }
}