namespace ListAssignment
{
    public class Item 
    {
        public string description { get; protected set; }
        public string name { get; protected set; }

        public void ExitInventory(Inventory inventory)
        {
            inventory.ExitInventory(this);
        }

        private Inventory inventory;

    }
    public class ItemSelecter
    {
        List<List<Item>> items = new List<List<Item>>(5)
        {
            new List<Item>(4){ new Ring(), new Necklace(), new Charm(),new Brooch() },
            new List<Item>(4){ new Helmet(), new Breastplate(), new Gloves(),new Shoes() },
            new List<Item>(4){ new Chicken(), new Stake(), new Fish(),new Salad() },
            new List<Item>(4){ new HealingPotion(), new ManaPotion(), new ExpPotion(),new StrangePotion() },
            new List<Item>(4){ new Sword(), new Hammer(), new Spear(), new Axe()}
        };
        public ItemSelecter(Inventory inventory)
        {
            EnterInventory(inventory);
        }
        public void EnterInventory(Inventory inventory)
        {
            inventory.EnterInventory(SelectItem());
        }

        private Item SelectItem()
        {
            List<Item> type = items[Util.GetRandomNumber(0, 5)];
            return type[Util.GetRandomNumber(0, 4)];
        }
    }

}

