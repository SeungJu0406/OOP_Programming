using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelTest4
{
    public class KeyInput
    {
        Func<int> OnPushKey;
        public KeyInput()
        {
            
        }
        public int KeyInput()
        {
            if(int.TryParse(Console.ReadLine(),out int key))
            {
                // 여기에 키보드 몇번을 눌렀는가 체크하게 할거임
                // 왠만하면 if문으로 몇 아래 눌렀는지 체크가 좋을듯
            }
            else
            {
                return Int32.MaxValue;
            }
        }
    }
}
