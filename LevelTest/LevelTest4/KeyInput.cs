using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelTest4
{
    public class KeyInput
    {
        public Action<int> OnPushKey;
        Map map;
        public KeyInput()
        {
            
        }
        public void PushKey()
        {
            
            if(int.TryParse(Console.ReadLine(),out int key))
            {                
                OnPushKey?.Invoke(key);
            }
        }
    }
}
