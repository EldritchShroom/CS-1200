namespace GuessingGame.Implementations;

public class RandomNumberGenerator : INumberGenerator
{
    public int MinNumber { get; set; }

    public int MaxNumber { get; set; }

    public RandomNumberGenerator(int minNumber, int maxNumber)
    {

        MinNumber = minNumber;

        MaxNumber = maxNumber;

    }

    public int GenerateNumber()
    {
        Random Num = new Random();

        int RandomNumber = Num.Next(MinNumber, MaxNumber);

        return RandomNumber;
        
    }
}