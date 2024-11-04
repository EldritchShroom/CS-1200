namespace Atlas.RPG.Items.Containers;

public class TypeRestrictedInventory : InventoryBase
{

    protected ItemType _requiredType { get; set; }
    public TypeRestrictedInventory(int _capacity, ItemType requiredType) : base(_capacity)
    {
        ItemType _requiredType = requiredType;
    }

    public override AddResult AddItem(ItemBase item)
    {
        for (int i = 0; i < _capacity - 1; i++)
        {
            if (_contents[i] == null && _requiredType == item.ItemType)
            {
                    _contents[i] = item;
                    return AddResult.Success;
            }  
        }
        return AddResult.WrongType;
    }


}