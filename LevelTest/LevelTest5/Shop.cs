using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LevelTest5
{
    public class Shop : IEnter
    {
        List<Item> items;


        public Shop()
        {
            items = new List<Item>()
            {
                new Weapon(),
                new Armor(),
                new Potion(),
            };
        }       

        public void PrintLobby()
        {
            Console.WriteLine("1. 아이템 구매");
            Console.WriteLine("2. 아이템 판매");
            Console.WriteLine("3. 아이템 확인");
            Console.Write("메뉴를 선택하세요 : ");
        }
        public void PrintShop(Player player)
        {
            Console.Clear();
            Console.WriteLine("================ 아이템 구매 ================");
            Console.WriteLine($"보유한 골드: {player.gold}G");
            Console.WriteLine();
            for (int i = 0; i < items.Count; i++) 
            {
                Console.WriteLine($"{i+1}. {items[i].name}");
                Console.WriteLine($" 가격: {items[i].price}G");
                Console.WriteLine($" 설명: {items[i].description}");
                Console.WriteLine($" 효과: {items[i].effect}");
                Console.WriteLine();
            }
            Console.Write("구매할 아이템을 선택하세요 (뒤로가기 0) : ");
        }           
        public void BuyItem(int index,Player player)
        {
            index--;
            player.gold -= items[index].price;
            player.GetItem(items[index]);
        }

        public void Enter(Player player)
        {
            PrintShop(player); 
        }

    }
}
