namespace Atlas.RPG.Items;

abstract class ItemBase
{
    public string Name { get; set; }
    public string Description { get; set; }
    public double Weight { get; set; }
    public decimal Value { get; set; }
}