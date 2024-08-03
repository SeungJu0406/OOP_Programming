namespace LevelTest6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map();
            Player player = new Player();
            while (true)
            {
                map.PrintChoiceMap();
                map.ChooseMap(player);
            }
        }
    }
}
