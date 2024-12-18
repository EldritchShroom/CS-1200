using Atlas.RPG.Items;
using Atlas.RPG.Items.Containers;

namespace Atlas.RPG.UI;

public class Tests
{
    public static void RunBaseTests()
    {
        // create container with 2 slots
        var container = new Chest(2);

        var item1 = new ItemBase {
            Name = "Item 1"
        };

        var item2 = new ItemBase {
            Name = "Item 2"
        };

        var item3 = new ItemBase {
            Name = "Item 3"
        };

        Console.WriteLine("Add Items Tests");
        Console.WriteLine($"Can add first item: {container.AddItem(item1)}");
        Console.WriteLine($"Can add second item: {container.AddItem(item2)}");
        Console.WriteLine($"Cannot add third item: {!container.AddItem(item3)}");
        
        Console.WriteLine("\nRemove Items Tests");
        var removed = container.RemoveItem(1);
        Console.WriteLine($"Can remove item: {removed != null}");
        Console.WriteLine($"Removed expected item: {removed == item2}");
        Console.WriteLine($"Removed slot is now null: {container.RemoveItem(1) == null}");

        Console.WriteLine("Create cloth bag");
        ClothBag Balenciaga = new ClothBag();
        Console.WriteLine($"Cloth bag is now called {Balenciaga}");

        container.ListContents();
    }
}