namespace ListAssignment
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            KeyInput keyInput = new KeyInput();
            while (gameData.runningGame)
            {
                inventory.PrintInventory();
                keyInput.PushKey(inventory);
            }
        }
        static GameData gameData = new GameData();
        struct GameData
        {
            public bool runningGame;
            public GameData()
            {
                runningGame = true;
            }
        }

    }
}
