namespace LevelTest6
{
    public class Player
    {
        public int gold { get; set; }
        public int power { get; set; }
        public int defense { get; set; }
        public int hp { get; set; }
        public Item[] equipList { get; private set; }
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
        }
        public void ThrowItem(Item item)
        {

            inventory.Remove(item);

        }
        public void UseItem(int key)
        {
            Item item = inventory[key - 1];
            if (item is ActiveItem)
            {
                item.BeEffect(this);
                inventory.RemoveAt(key - 1);
            }
            if (item is PassiveItem)
            {
                EquipItem(item);
                inventory.RemoveAt(key - 1);
            }
        }

        public void PrintCheckItem()
        {
            Console.Clear();
            Console.WriteLine("================ 아이템 확인 ================");
            Console.WriteLine($"플레이어 골드\t 보유량: {gold}G");
            Console.WriteLine($"플레이어 공격력\t 상승량: {power}");
            Console.WriteLine($"플레이어 방어력\t 상승량: {defense}");
            Console.WriteLine($"플레이어 체력\t 상승량: {hp}");
            Console.WriteLine();
            FuncPlayerInventory();
            Console.Write("사용할 아이템을 선택하세요 (뒤로가기 0) : ");
        }

        private void EquipItem(Item item)
        {
            if (item is Weapon)
            {
                WearEquipment(item, 0);
            }
            if(item is Armor)
            {
                WearEquipment(item, 1);
            }
        }

        private void UnEquipItem(Item item)
        {
            if (item is Weapon)
            {
                equipList[0] = null;
                item.NotEffect(this);
            }
            if(item is Armor)
            {
                equipList[1] = null;
                item.NotEffect(this);
            }
        }

        private void WearEquipment(Item item ,int index)
        {
            if (equipList[index] != null)
            {
                inventory.Add(equipList[index]);
                equipList[index] = null;
                item.NotEffect(this);
            }
            equipList[index] = item;
            item.BeEffect(this);
        }
        private void FuncPlayerInventory()
        {
            for (int i = 0; i < inventory.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {inventory[i].name}");
                Console.WriteLine($" 가격: {inventory[i].price}G");
                Console.WriteLine($" 설명: {inventory[i].description}");
                Console.WriteLine($" 효과: {inventory[i].effect}");
                Console.WriteLine();
            }
        }
    }
}
