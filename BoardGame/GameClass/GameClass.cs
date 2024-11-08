namespace BoardGame;

public class GameBoard
{
    public string Name { get; set; }

    public int MinPlayers { get; set; }

    public int MaxPlayers { get; set; }

    private int PlayTime;


    public GameBoard(string name, int minPlayers, int maxPlayers)
    {
        Name = name;

        MinPlayers = minPlayers;

        MaxPlayers = maxPlayers;
    }


    public virtual void Play()
    {
        Console.WriteLine("Playing the board game.");
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Currently playing {Name}");
    }
}