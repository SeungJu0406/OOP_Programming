namespace LevelTest6
{
    public class Sea : MapData
    {
        enum SeaPlace { Lobby, CatchFish, CheckFish, CheckItem, SIZE }
        SeaPlace nowPlace;
        List<Fish> fishs;
        List<Fish> caughtFish;
        int countFish;
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
                case SeaPlace.CatchFish:
                    PrintCatchFish();
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
                        ChooseLobby(key);
                        break;
                    case SeaPlace.CatchFish:
                        ChooseCatchFish(key, player);
                        break;
                    case SeaPlace.CheckFish:
                        ChooseCheckFish(key);
                        break;
                    case SeaPlace.CheckItem:
                        ChooseCheckItem(key, player);
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
        private void PrintCatchFish()
        {           
            Console.Clear();
            Console.WriteLine("============== 낚 시 중 ==============");
            Console.WriteLine();
            Console.WriteLine("1. 낚 시");
            Console.WriteLine();
            if (countFish < caughtFish.Count)
            {
                Console.WriteLine(" 생선을 잡았습니다!");
                Console.WriteLine();
                countFish++;
            }
            Console.Write("뒤로 가려면 0을 입력하세요 : ");
            
        }
        private void PrintCheckFish()
        {
            Console.Clear();
            Console.WriteLine("============= 생선 확인 =============");
            Console.WriteLine();
            for (int i = 0; i < caughtFish.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {caughtFish[i].name}");
            }
            Console.WriteLine();
            Console.WriteLine("뒤로가시려면 0을 입력하십시오 : ");
        }
        private void PrintCheckItem(Player player)
        {
            player.PrintCheckItem();
        }
        private void ChooseLobby(int key)
        {
            if (key == 0)
            {
                ExitSea();
            }
            switch (key)
            {
                case (int)SeaPlace.CatchFish:
                    EnterCatchFish();
                    break;
                case (int)SeaPlace.CheckFish:
                    EnterCheckFish();
                    break;
                case (int)SeaPlace.CheckItem:
                    EnterCheckItem();
                    break;
                default:
                    break;
            }
        }
        private void ChooseCatchFish(int key, Player player)
        {
            if (key == 0)
            {
                EnterLobby();
            }
            if (key == 1)
            {
                CatchFish(player);
            }
        }
        private void ChooseCheckFish(int key)
        {
            if (key == 0)
            {
                EnterLobby();
            }
        }
        private void ChooseCheckItem(int key, Player player)
        {
            player.CheckItem(key, this);
        }
        public override void EnterLobby()
        {
            nowPlace = SeaPlace.Lobby;
        }
        private void EnterCatchFish()
        {
            nowPlace = SeaPlace.CatchFish;
        }
        private void EnterCheckFish()
        {
            nowPlace = SeaPlace.CheckFish;
        }
        private void EnterCheckItem()
        {
            nowPlace = SeaPlace.CheckItem;
        }
        private void ExitSea()
        {
            caughtFish.Clear();
            isPlace = false;
        }
        private void CatchFish(Player player)
        {
            Fish fish = fishs[Util.Random(0, 2)];
            caughtFish.Add(fish);
            player.GetItem(fish);
        }
    }
}
