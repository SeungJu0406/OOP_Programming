using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LevelTest6
{
    public class Sea : MapData
    {
        List<Fish> fishs;
        public Sea()
        {
            id = (int)MapName.Sea;
            name = "바다";
            fishs = new List<Fish>()
            {
                new Mackerel(),
                new Squid(),
                new Bass(),
            };           
        }
        public override void PrintPlace(Player player)
        {

        }
        public override void WaitChoice(Player player)
        {
            
        }
        private void PrintLobby()
        {
            Console.Clear();
            Console.WriteLine("============= 바 다 =============");
            Console.WriteLine();
            Console.WriteLine("1. 낚시하기");
            Console.WriteLine("2. 낚은 생선 확인");
            Console.WriteLine("3. 아이템 확인");
            Console.WriteLine();
            Console.WriteLine("행동할 선택지를 고르시오 (돌아가기 0) : ");
        }
    }
}
