using System.Threading.Channels;

namespace LevelTest4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map();
            KeyInput keyInput = new KeyInput();
            keyInput.OnPushKey += map.ChooseMap;
            while (true)
            {
                map.PrintChoiceMap();
                keyInput.PushKey();
            }
        }
    }    
}
