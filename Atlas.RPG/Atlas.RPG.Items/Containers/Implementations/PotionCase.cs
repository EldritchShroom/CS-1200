namespace Atlas.RPG.Items.Containers;

public class PotionCase : TypeRestrictedInventory
{
    public PotionCase()
    {
        _requireType = Potion;
        _capacity = 10;
    }

}