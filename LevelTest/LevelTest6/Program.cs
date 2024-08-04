namespace LevelTest6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Road map = new Road();
            Player player = new Player();
            while (true)
            {
                map.PrintChoiceMap();
                map.ChooseMap(player);
            }
        }
    }
}
