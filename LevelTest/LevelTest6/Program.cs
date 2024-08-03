namespace LevelTest6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map();
            while (true)
            {
                map.PrintChoiceMap();
                map.ChooseMap();
            }
        }
    }
}
