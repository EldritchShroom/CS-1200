namespace HangMan.BLL
{
    public class GameState
    {
        private string _wordToGuess;
        private string _currentPuzzle;
        private int _strikesRemaining;
        private List<char> _guessedLetters;
        private readonly IWordSource _wordSource;

        public GameState(IWordSource wordSource)
        {
            _wordSource = wordSource;
            _guessedLetters = new List<char>();
            _strikesRemaining = 5; // You can adjust this as needed
        }

        public void StartNewGame()
        {
            _wordToGuess = _wordSource.GetWord();
            _currentPuzzle = new string('_', _wordToGuess.Length); // Set up the puzzle with underscores
            _guessedLetters.Clear(); // Clear past guesses
            _strikesRemaining = 5; // Reset strikes
            DisplayPuzzle();
        }

        public void ProcessGuess(string guess)
        {
            if (guess.Length == 1) // If the player guessed a letter
            {
                ProcessLetterGuess(guess[0]);
            }
            else // If the player guessed the whole word
            {
                ProcessWordGuess(guess);
            }

            DisplayPuzzle();
        }

        private void ProcessLetterGuess(char letter)
        {
            if (_guessedLetters.Contains(letter)) 
            {
                Console.WriteLine($"You already guessed '{letter}'. Try another letter.");
                return;
            }

            _guessedLetters.Add(letter);

            if (_wordToGuess.Contains(letter))
            {
                Console.WriteLine($"Correct! '{letter}' is in the word.");
                UpdatePuzzleState(letter);
            }
            else
            {
                Console.WriteLine($"Sorry, '{letter}' is not in the word.");
                _strikesRemaining--;
            }
        }

        private void ProcessWordGuess(string wordGuess)
        {
            if (wordGuess.Equals(_wordToGuess, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Congratulations! You've guessed the word: {wordGuess}");
                _currentPuzzle = _wordToGuess;
            }
            else
            {
                Console.WriteLine($"Incorrect! '{wordGuess}' is not the word.");
                _strikesRemaining--;
            }
        }

        private void UpdatePuzzleState(char letter)
        {
            char[] puzzleArray = _currentPuzzle.ToCharArray();
            for (int i = 0; i < _wordToGuess.Length; i++)
            {
                if (_wordToGuess[i] == letter)
                {
                    puzzleArray[i] = letter;
                }
            }
            _currentPuzzle = new string(puzzleArray);
        }

        private void DisplayPuzzle()
        {
            Console.Clear();
            Console.WriteLine($"Strikes Remaining: {_strikesRemaining}");
            Console.WriteLine($"Word: {_currentPuzzle}");
            Console.WriteLine($"Guessed Letters: {string.Join(", ", _guessedLetters)}");
        }

        public bool IsGameOver()
        {
            return _strikesRemaining == 0 || _currentPuzzle.Equals(_wordToGuess, StringComparison.OrdinalIgnoreCase);
        }

        public string GetCurrentPuzzle()
        {
            return _currentPuzzle;
        }

        public int GetStrikesRemaining()
        {
            return _strikesRemaining;
        }
    }
}