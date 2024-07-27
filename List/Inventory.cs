using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ListAssignment
{
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
            new ItemSelecter(this);
        }
        public void ReadExitItem(int i)
        {
            if (i>inventory.Count) // 인벤토리 총량보다 입력숫자가 더 크면 못뺌
                return;
            inventory.RemoveAt(i-1);
        }
        public void EnterInventory(Item item)
        {           
            inventory.Add(item);
        }
        //public void ExitInventory(Item item)
        //{
        //    inventory.Remove(item);
        //}
        public void PrintInventory()
        {
            Console.Clear();
            foreach (Item item in inventory)
            {             
                Console.WriteLine($"[{++index}] {item.name}: {item.description}");                
            }
            index = 0;
        }
        private int index;
    }
}
