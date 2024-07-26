using System.Reflection.Metadata.Ecma335;

namespace ListAssignment
{
    public class Item
    {
        public string description { get; protected set; }
        public string name { get; protected set; }
        
        public void EnterInventory(Inventory inventory)
        {
            inventory.EnterInventory(this);
        }
        public void ExitInventory(Inventory inventory)
        {
            inventory.ExitInventory(this);
        }
        private Inventory inventory;
    }
    public class ItemSelecter 
    {
        List<List<Item>> item = new List<List<Item>>()
        {
            new List<Item>{ new Ring(), new Necklace(), new Charm(),new Brooch() },
            new List<Item>{ new Helmet(), new Breastplate(), new Gloves(),new Shoes() },
            new List<Item>{ new Chicken(), new Stake(), new Fish(),new Salad() },
            new List<Item>{ new HealingPotion(), new ManaPotion(), new ExpPotion(),new StrangePotion() },
            new List<Item>{ new Sword(), new Hammer(), new Spear(), new Axe()}
        };
        public Item SelectItem()
        {
            List<Item> type = item[Util.GetRandomNumber(0, 5)];
            return type[Util.GetRandomNumber(0, 4)];
        }
    }

}
