namespace HangMan.UI
{
    public class Program
    {
        static void Main()
        {
            UserInput userInput = new UserInput();
            IWordSource wordSource = null;

            int choice = userInput.GuessChoice();
            if (choice == 1)
            {
                wordSource = new UserWord(); // Get word from user input
            }
            else if (choice == 2)
            {
                wordSource = new RandomWord(); // Get word from random dictionary
            }

            GameState gameState = new GameState(wordSource);

            bool continuePlaying = true;
            while (continuePlaying)
            {
                gameState.StartNewGame();

                while (!gameState.IsGameOver())
                {
                    Console.Write("Enter your guess: ");
                    string guess = Console.ReadLine().ToLower(); // Case-insensitive guess
                    gameState.ProcessGuess(guess);
                }

                Console.WriteLine("Game Over!");
                Console.WriteLine($"The word was: {gameState.GetCurrentPuzzle()}");

                Console.Write("Would you like to play again? (y/n): ");
                string playAgain = Console.ReadLine().ToLower();
                if (playAgain != "y")
                {
                    continuePlaying = false;
                }
            }
        }
    }
}