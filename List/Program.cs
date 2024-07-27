namespace ListAssignment
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            KeyInput keyInput = new KeyInput();
            while (true)
            {
                inventory.PrintInventory();
                keyInput.PushKey(inventory);
            }
        }

    }
}
