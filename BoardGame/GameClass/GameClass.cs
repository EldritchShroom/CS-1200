namespace BoardGame;

public class GameBoard
{
    public string Name { get; set; }

    public int MinPlayers { get; set; }

    public int MaxPlayers { get; set; }

    public int PlayTime { get; set; }

    public int PlayerRange { get; set; }


    public GameBoard(string name, int minPlayers, int maxPlayers, int playTime, int playerRange)
    {
        Name = name;

        MinPlayers = minPlayers;

        MaxPlayers = maxPlayers;

        PlayTime = playTime;

        PlayerRange = playerRange;
    }

    public void Play()
    {
        Console.WriteLine("Playing the board game.");
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Currently playing {Name}");
        Console.WriteLine($"Player Range is {PlayerRange}");
    }
}