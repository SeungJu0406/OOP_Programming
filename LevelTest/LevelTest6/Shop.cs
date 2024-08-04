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
            player.FuncPlayerInventory();
            Console.Write("판매할 아이템을 선택하세요 (뒤로가기 0) : ");
        }

        private void PrintCheckItem(Player player)
        {
            player.PrintCheckItem();
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
                EnterLobby();
            if (0 < key && key <= items.Count)
            {
                BuyItem(key, player);
            }
        }
        private void ChooseSellShop(int key, Player player)
        {

            if (key == 0)
                EnterLobby();
            if (0 < key && key <= player.inventory.Count)
            {
                SellItem(key, player);
            }
        }
        private void ChooseCheckItem(int key, Player player)
        {
            player.CheckItem(key, this);
        }
        public override void EnterLobby()
        {
            nowPlace = ShopPlace.Lobby;
        }
        private void EnterBuyShop(Player player)
        {
            nowPlace = ShopPlace.BuyShop;
        }
        private void EnterSellShop(Player player)
        {
            nowPlace = ShopPlace.SellShop;
        }
        private void EnterCheckItem(Player player)
        {
            nowPlace = ShopPlace.CheckItem;
        }
        private void ExitShop(Player player)
        {
            isPlace = false;
        }

    }
}
