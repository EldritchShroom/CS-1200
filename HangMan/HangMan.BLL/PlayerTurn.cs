namespace HangMan.BLL;

public class PlayerTurn
{
    private int Strikes = 5;

    public void WordSpace()
    {
        for (int i = 0; i < _word.Length; i++)
        {
            if (_word[i] == guess)
            {
                Console.Write($"{_word[i] }");
            }
        }
    }
}