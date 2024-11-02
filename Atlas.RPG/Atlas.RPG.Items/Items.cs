namespace Atlas.RPG.Items;

public class ItemBase
{
    public string Name { get; set; }
    public string Description { get; set; }
    public double Weight { get; set; }
    public decimal Value { get; set; }
    public ItemType itemType;
}

public enum ItemType
{
    Weapon,
    Armor,
    Potion
}