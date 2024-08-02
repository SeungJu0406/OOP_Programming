using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelTest5
{
    public class Player
    {
        public int gold {  get; set; }
        public int power { get; private set; }
        public int defense { get; private set; }
        public int hp { get; private set; }
        public Item[] equipList {  get; private set; }
        public List<Item> inventory; 
        public Player()
        {
            gold = 3000;
            power = 0; 
            defense = 0; 
            hp = 0;
            equipList = new Item[2];
            inventory = new List<Item>(5);
        }
        public void GetItem(Item item)
        {
            inventory.Add(item);
            if (item is Weapon) EquipWeapon(item);
            if (item is Armor) EquipArmor(item);
        }
        public void EquipWeapon(Item weapon)
        {
            equipList[0] = weapon;
        }
        public void EquipArmor(Item armor)
        {
            equipList[1] = armor;
        }
    }
}
