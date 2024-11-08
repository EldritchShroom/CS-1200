namespace BoardGame.RiskGame;

public class Risk : GameBoard
{
   Random DiceRoll = new Random();

   private int Troops { get; set; }

   
   public override void Play()
   {
      Console.WriteLine("Welcome to Risk, Do you have what it takes to conquer your foes?");
   }

   public override void DisplayInfo()
   {
      Console.WriteLine();
   }



}