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
        enum SeaPlace { Lobby = 1, CheckFish, CheckItem ,SIZE}
        SeaPlace nowPlace;
        List<Fish> fishs;
        List<Fish> caughtFish;
        public Sea()
        {
            id = (int)MapName.Sea;
            name = "바다";
            caughtFish = new List<Fish>();
            fishs = new List<Fish>()
            {
                new Mackerel(),
                new Squid(),
                new Bass(),
            };
            nowPlace = SeaPlace.Lobby;
        }
        public override void PrintPlace(Player player)
        {
            switch (nowPlace)
            {
                case SeaPlace.Lobby:
                    PrintLobby();
                    break;
                case SeaPlace.CheckFish:
                    PrintCheckFish();
                    break;
                case SeaPlace.CheckItem:
                    PrintCheckItem(player);
                    break;
                default:
                    break;
            }
        }
        public override void WaitChoice(Player player)
        {
            if (int.TryParse(Console.ReadLine(), out int key)) 
            {
                switch (nowPlace)
                {
                    case SeaPlace.Lobby:
                        //ChooseLobby(key);
                        break;
                }
            }           
            else
                return;
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
        private void PrintCheckFish()
        {
            Console.Clear();
            Console.WriteLine("============= 생선 확인 =============");
            Console.WriteLine();
            for (int i = 0; i < caughtFish.Count; i++) 
            {
                Console.WriteLine($"{i+1}. {caughtFish[i].name}");
            }
            Console.WriteLine();
            Console.WriteLine("뒤로가시려면 0을 입력하십시오 : ");
        }
        private void PrintCheckItem(Player player)
        {
            player.PrintCheckItem();
        }
        //private void ChooseLobby(int key)
        //{
        //    if(key == 0)
        //    {
        //        ExitSea();
        //    }
        //    if(key == 1)
        //    {
        //        EnterCatchFish();
        //    }
        //}
        //private void ChooseCheckFish(int key)
        //{
        //    if (key == 0)
        //    {
        //        EnterLobby();
        //    }                
        //}
        //private void ChooseCheckItem(int key, Player player)
        //{
        //    if(key ==0)
        //    {
        //        EnterLobby();
        //    }
            
        //}
    }
}
