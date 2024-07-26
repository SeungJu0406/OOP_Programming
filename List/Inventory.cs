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
        List<Item> inventory { get; set; }
        public Inventory()
        {
            inventory = new List<Item>(9);
        }
        public void EnterInventory(Item item)
        {
            inventory.Add(item);
        }
        public void ExitInventory(Item item)
        {
            inventory.Remove(item);
        }
        public void PrintInventory()
        {
            foreach (Item item in inventory)
            {
                Console.WriteLine($"{item.name}: {item.description}");
            }
        }
    }
}
