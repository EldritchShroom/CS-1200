using System.Runtime.CompilerServices;

namespace Atlas.RPG.Items.Containers;

    public abstract class InventoryBase
    {
        protected int _capacity;
        protected ItemBase[] _contents;

        public InventoryBase(int capacity)
        {
            _capacity = capacity;
            _contents = new ItemBase[_capacity];
        }

        public virtual AddResult AddItem(ItemBase item)
        {
                if (_contents[i] == null)
                {
                    
                    _contents[i] = item;
                    return AddResult.Success;
                }
        }
        

        public virtual ItemBase RemoveItem(int index)
        {
            if (index >= 0 && index < _capacity)
            {
                ItemBase item = _contents[index];
                if (item != null)
                {
                    _contents[index] = null;
                    return item;
                }
            }
            return null;
        }
        
        public virtual void ListContents()
        {
            Console.WriteLine("Contents");
            Console.WriteLine();
            Console.WriteLine("=================");

            
            for (int i = 0; i < _capacity - 1; i++)
            {
                string itemType = _contents[i].ItemType.ToString();
                string itemName = _contents[i].Name;
                double itemWeight = _contents[i].Weight;
                decimal itemValue = _contents[i].Value; 
                
                if (_contents[i] != null)
                {
                    Console.WriteLine($"{itemType,-10}\t\t| {itemName,-20} | {itemWeight,7}kg | {itemValue,6}");
                }
            }
        }
    }