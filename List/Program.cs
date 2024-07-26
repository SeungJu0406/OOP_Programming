namespace ListAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            Item healpotion = new HealingPotion();
            Item fish = new Fish();
            healpotion.EnterInventory(inventory);
            fish.EnterInventory(inventory);
            inventory.PrintInventory();
            fish.ExitInventory(inventory);
            inventory.PrintInventory();

        }
    }
}
