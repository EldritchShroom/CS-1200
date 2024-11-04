namespace Atlas.RPG.Items.Containers;

public class ClothBag : WeightRestrictedInventory
{
    public ClothBag(int capacity, double maxWeight) : base(capacity, maxWeight)
    {
        _capacity = capacity;
        _maxWeight = 5;
    }
}