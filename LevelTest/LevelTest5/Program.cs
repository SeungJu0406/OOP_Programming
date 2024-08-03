namespace LevelTest5
{
    public class Program
    {        
        static void Main(string[] args)
        {
            Shop shop = new Shop();
            Player player = new Player();
            while (shop.isInShop) 
            {
                shop.PrintShop(player);
                shop.WaitChoice(player);
            }          
        }
    }
}
