namespace LevelTest5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();
            Player player = new Player();
            shop.Enter(player);
            shop.BuyItem(3, player);
            shop.Enter(player);
            
        }
    }
}
