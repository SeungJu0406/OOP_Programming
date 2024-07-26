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

}
