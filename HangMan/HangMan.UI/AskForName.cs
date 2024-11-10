namespace HangMan.UI;

public class AskName
{
    public string _askName()
    {
        Console.Write("Enter your name: ");
        string Name = Console.ReadLine();

        return Name;
    }
}