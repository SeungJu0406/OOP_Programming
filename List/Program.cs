namespace ListAssignment
{
    internal static class Program
    {       
        static void Main(string[] args)
        {         
            ItemSelecter itemSelecter = new ItemSelecter();
            Inventory inventory = new Inventory();
            Item item1 = itemSelecter.SelectItem();
            item1.EnterInventory(inventory);
            inventory.PrintInventory();
        }       
    }
}
