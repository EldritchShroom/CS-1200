using System;

namespace HangMan.UI;

public class HangMan
{
    public void GameLoop()
    {
        Boolean isTrue = true;

        while (isTrue)
        {
            Console.WriteLine("Welcome to Hangman!");
            Console.WriteLine();

            /*
            This part was put into "AskForName.cs"
            Console.Write("Enter your name: ");
            Console.WriteLine();
            */

            /* 
            This part was put into "GuessHandling.cs"
            Console.WriteLine("How would you like to choose your words?");

            Console.Write("1. Enter the word in the console window.");
            Console.Write("2. Pick a random word from the dictionary for me.");

            int input = int.Parse(Console.ReadLine());
            */
        }
    }
}