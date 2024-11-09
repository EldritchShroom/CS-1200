namespace HangMan.BLL;

public class UserWord : IWordSource
{
    public string GetWord()
    {
        Console.Write("Enter the word to guess.");
        string _userWord = Console.ReadLine(); // This should ask for a word and then store it in our variable. 

        return _userWord; // It feels to simple but it makes sense, ask for input and store that inside of a variable then return what the user input
    }
}