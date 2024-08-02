namespace LevelTest4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map();
            map.MoveMap(1,2);
            map.MoveMap(2, 3);
            map.MoveMap(3, 7);
            map.PrintChoiceMap();
        }
    }    
}
