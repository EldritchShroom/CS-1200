namespace Atlas.RPG.Items.Containers;

public class WeightRestrictedInventory : InventoryBase
{   
    protected double _currentWeight;

    protected double _maxWeight { get; set; }


    public WeightRestrictedInventory(int capacity, double maxWeight) 
        : base(capacity)
    {
        _maxWeight = maxWeight;
    }
    // ^^ Constructor

    public override AddResult AddItem(ItemBase item)
    {
        for (int i = 0; i < _capacity - 1; i++)
        {
            if (_contents[i] == null && _currentWeight + item.Weight < _maxWeight)
            {
                _currentWeight += item.Weight;
                _contents[i] = item;
                return AddResult.Success;
            }
            return AddResult.Overweight;
        }
        
    }

    public override ItemBase RemoveItem(int index)
    {
        if (index >= 0 && index < _capacity)
            {
                ItemBase item = _contents[index];
                if (item != null)
                {
                    _contents[index] = null;
                    _currentWeight -= item.Weight;
                    return item;
                }
            }
            return null;
    }

}