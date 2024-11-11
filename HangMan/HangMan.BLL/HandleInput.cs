using System;

namespace HangMan.UI;

public class UserInput
{
    public string _askName()
    {
        Console.Write("Enter your name: ");
        string Name = Console.ReadLine();

        return Name;
    }

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