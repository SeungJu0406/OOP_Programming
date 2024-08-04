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
        /// <summary>
        /// 아이템 얻기
        /// </summary>
        /// <param name="item"></param>
        public void GetItem(Item item)
        {
            inventory.Add(item);
        }
        /// <summary>
        /// 아이템 버리기
        /// </summary>
        /// <param name="item"></param>
        public void ThrowItem(Item item)
        {
            inventory.Remove(item);
        }

        /// <summary>
        /// 아이템 확인 화면
        /// </summary>
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
        /// <summary>
        /// 아이템 확인 키 입력
        /// </summary>
        /// <param name="key"></param>
        /// <param name="map"></param>
        public void CheckItem(int key, Map map)
        {
            if (key == 0)
                map.EnterLobby();
            if (0 < key && key <= inventory.Count)
            {
                UseItem(key);
            }
        }
        /// <summary>
        /// 아이템 사용
        /// </summary>
        /// <param name="key"></param>
        private void UseItem(int key)
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
        /// <summary>
        /// 장비 입기
        /// </summary>
        /// <param name="item"></param>

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
        /// <summary>
        /// 장비 벗기
        /// </summary>
        /// <param name="item"></param>
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
        /// <summary>
        /// 장비 입기 함수
        /// </summary>
        /// <param name="item"></param>
        /// <param name="index"></param>
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
        /// <summary>
        /// 인벤토리 확인 함수
        /// </summary>
        public void FuncPlayerInventory()
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
