using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ListAssignment
{
    /// <summary>
    /// 인벤토리
    /// 인벤토리 안에 아이템을 넣고 빼는 기능
    /// PrintInventory(); 를 통해 인벤토리 내부 확인 가능
    /// </summary>
    public class Inventory
    {
        public List<Item> inventory { get; set; }
        public Inventory()
        {
            inventory = new List<Item>(9);
        }
        public void ReadyEnterItem()
        {
            if (inventory.Count >= 9) // 쓸데없이 객체 만들지 말고 9개 가득차면 여기서 끊어버림
                return;
            new ItemSelecter(this); // 아이템 선택 인스턴스 생성후에 다시 돌아와서 인벤토리에 템 들어감
        }
        public void ReadExitItem(int i)
        {
            if (i>inventory.Count) // 인벤토리 총량보다 입력숫자가 더 크면 못뺌
                return;
            inventory.RemoveAt(i-1);
            return;
        }
        public void EnterInventory(Item item)
        {           
            inventory.Add(item); // 인벤토리에 템넣기
        }
        public void PrintInventory()
        {
            Console.Clear();
            Console.WriteLine("인벤토리");
            Console.WriteLine("========================================");
            foreach (Item item in inventory)
            {             
                Console.WriteLine($"[{++index}] {item.name}: {item.description}");                
            }
            index = 0;
            Console.WriteLine("========================================");
        }
        private int index;
    }
}
