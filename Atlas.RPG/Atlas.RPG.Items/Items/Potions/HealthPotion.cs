namespace Atlas.RPG.Items.Potions;

public class HealthPotion : ItemBase
{
    public override Drink()
    {
        Console.WriteLine("Glug, Glug, Glug! You feel better!");
    }

    public HealthPotion()
    {
        ItemType = ItemType.Potion;
        Name = "Health Potion";
        Weight = 1;
        Description = " Small potion that heals.";
        Value = 10;
    }
}