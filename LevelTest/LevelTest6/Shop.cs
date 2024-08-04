using System.Numerics;

namespace LevelTest6
{
    public class Shop : MapData
    {
        enum ShopPlace { Lobby = 1, BuyShop, SellShop, CheckItem, SIZE }
        List<Item> items;
        ShopPlace nowPlace;        

        public Shop()
        {
            items = new List<Item>()
            {
                new Weapon(),
                new Armor(),
                new Potion(),
            };
            nowPlace = ShopPlace.Lobby;          
            id = (int)MapName.Shop;
            name = "상점";
        }
        public override void PrintPlace(Player player)
        {
            switch (nowPlace)
            {
                case ShopPlace.Lobby:
                    PrintLobby();
                    break;
                case ShopPlace.BuyShop:
                    PrintBuyShop(player);
                    break;
                case ShopPlace.SellShop:
                    PrintSellShop(player);
                    break;
                case ShopPlace.CheckItem:
                    PrintCheckItem(player);
                    break;
                default:
                    break;
            }
        }
        public override void WaitChoice(Player player)
        {
            if (int.TryParse(Console.ReadLine(), out int key)) ;
            else
                return;
            switch (nowPlace)
            {
                case ShopPlace.Lobby:
                    ChooseLobby(key, player);
                    break;
                case ShopPlace.BuyShop:
                    ChooseBuyShop(key, player);
                    break;
                case ShopPlace.SellShop:
                    ChooseSellShop(key, player);
                    break;
                case ShopPlace.CheckItem:
                    ChooseCheckItem(key, player);
                    break;
                default:
                    break;
            }
        }
        private void PrintLobby()
        {
            Console.Clear();
            Console.WriteLine("*********************************");
            Console.WriteLine("*          아이템 상점          *");
            Console.WriteLine("*********************************");
            Console.WriteLine();
            Console.WriteLine("========== 상점 메뉴 ===========");
            Console.WriteLine();
            Console.WriteLine("1. 아이템 구매");
            Console.WriteLine("2. 아이템 판매");
            Console.WriteLine("3. 아이템 확인");
            Console.WriteLine();
            Console.Write("메뉴를 선택하세요 (상점 나가기 0): ");
        }


        private void PrintBuyShop(Player player)
        {
            Console.Clear();
            Console.WriteLine("================ 아이템 구매 ================");
            Console.WriteLine($"보유한 골드: {player.gold}G");
            Console.WriteLine();
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {items[i].name}");
                Console.WriteLine($" 가격: {items[i].price}G");
                Console.WriteLine($" 설명: {items[i].description}");
                Console.WriteLine($" 효과: {items[i].effect}");
                Console.WriteLine();
            }
            Console.Write("구매할 아이템을 선택하세요 (뒤로가기 0) : ");
        }

        private void PrintSellShop(Player player)
        {
            Console.Clear();
            Console.WriteLine("================ 아이템 판매 ================");
            Console.WriteLine($"보유한 골드: {player.gold}G");
            Console.WriteLine();
            FuncPlayerInventory(player);
            Console.Write("판매할 아이템을 선택하세요 (뒤로가기 0) : ");
        }

        private void PrintCheckItem(Player player)
        {
            player.PrintCheckItem();
            //Console.Clear();
            //Console.WriteLine("================ 아이템 확인 ================");
            //Console.WriteLine($"플레이어 골드\t 보유량: {player.gold}G");
            //Console.WriteLine($"플레이어 공격력\t 상승량: {player.power}");
            //Console.WriteLine($"플레이어 방어력\t 상승량: {player.defense}");
            //Console.WriteLine($"플레이어 체력\t 상승량: {player.hp}");
            //Console.WriteLine();
            //FuncPlayerInventory(player);
            //Console.Write("사용할 아이템을 선택하세요 (뒤로가기 0) : ");
        }

        private void BuyItem(int index, Player player)
        {
            int balance = player.gold - items[index - 1].price;
            if (balance >= 0)
            {
                player.gold = balance;
                player.GetItem(items[index - 1]);
            }
        }
        private void SellItem(int index, Player player)
        {
             player.gold += player.inventory[index-1].price;
            player.ThrowItem(player.inventory[index-1]);
        }
        private void UseItem(int key, Player player)
        {
            player.UseItem(key);
        }


        private void ChooseLobby(int key, Player player)
        {
            switch (key)
            {
                case 1:
                    EnterBuyShop(player);
                    break;
                case 2:
                    EnterSellShop(player);
                    break;
                case 3:
                    EnterCheckItem(player);
                    break;
                case 0:
                    ExitShop(player);                   
                    break;
                default:
                    break;
            }
        }
        private void ChooseBuyShop(int key, Player player)
        {
            if (key == 0)
                EnterLobby(player);
            if (0 < key && key <= items.Count)
            {
                BuyItem(key, player);
            }
        }
        private void ChooseSellShop(int key, Player player)
        {

            if (key == 0)
                EnterLobby(player);
            if (0 < key && key <= player.inventory.Count)
            {
                SellItem(key, player);
            }
        }
        private void ChooseCheckItem(int key, Player player)
        {
            if (key == 0)
                EnterLobby(player);
            if (0 < key && key <= player.inventory.Count)
            {
               UseItem(key, player);
            }
        }
        private void EnterLobby(Player player)
        {
            nowPlace = ShopPlace.Lobby;
            PrintPlace(player);
        }
        private void EnterBuyShop(Player player)
        {
            nowPlace = ShopPlace.BuyShop;
            PrintPlace(player);
        }
        private void EnterSellShop(Player player)
        {
            nowPlace = ShopPlace.SellShop;
            PrintPlace(player);
        }
        private void EnterCheckItem(Player player)
        {
            nowPlace = ShopPlace.CheckItem;
            PrintPlace(player);
        }
        private void ExitShop(Player player)
        {
            isPlace = false;
        }



        private void FuncPlayerInventory(Player player)
        {
            for (int i = 0; i < player.inventory.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {player.inventory[i].name}");
                Console.WriteLine($" 가격: {player.inventory[i].price}G");
                Console.WriteLine($" 설명: {player.inventory[i].description}");
                Console.WriteLine($" 효과: {player.inventory[i].effect}");
                Console.WriteLine();
            }
        }
    }
}
