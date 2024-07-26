namespace ListAssignment
{
    public static class Program
    {       
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            ItemSelecter item1 = new ItemSelecter();
            item1.EnterInventory(inventory);
            inventory.PrintInventory();
            inventory.inventory[0].ExitInventory(inventory);
            inventory.PrintInventory();




        }


    }

}
