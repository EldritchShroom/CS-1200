using System.Runtime.CompilerServices;

namespace HangMan.BLL;

public class RandomWord : IWordSource
{
    public string GetWord()
    {
        Random rnd = new();

        string homePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

        string filepath = Path.Combine(homePath, "OneDrive", "CS-1200", "HangMan", "dictionary.txt" );
        // The above code (because I am lazy) should get the entire path for you to use.

        string[] dictionaryWords = File.ReadAllLines(filepath); // Should now have all of the words in the array.

        string _word = dictionaryWords[rnd.Next(dictionaryWords.Length)];
        // This should use rnd to chose a random index which chooses a random word which is then stored to the string _word 
        return _word;

    }
} 