namespace HangMan.UI;

public class HandleGuess
{
    public int GuessChoice()
    {
        
        Console.WriteLine("How would you like to choose your words?");
        Console.WriteLine();
        Console.WriteLine("1. Enter the word in the console window.");
        Console.WriteLine("2. Pick a random word from the dictionary for me.");

        Console.Write("Enter choice: ");

        int input = int.Parse(Console.ReadLine());

        return input;
    }
}