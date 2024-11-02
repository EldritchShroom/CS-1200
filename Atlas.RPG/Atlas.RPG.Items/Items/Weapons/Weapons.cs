namespace Atlas.RPG.Items.Weapons;   

public class WeaponBase : ItemBase
{
    public int Damage {get; set;}
}

public class Sword : WeaponBase
{
    public Sword()
    {
        ItemType = ItemType.Weapon;
        Damage = 5;
        Name = "Iron Sword"
        Description = " A standard iron sword.";
        Weight = 4;
        Value = 100;    
    }
}