namespace ListAssignment
{
    /// <summary>
    /// 아이템
    /// 아이템 이름과 설명
    /// </summary>
    public class Item 
    {
        public string description { get; protected set; }
        public string name { get; protected set; }
    }
    /// <summary>
    /// 아이템 선택
    /// 랜덤으로 템을 생성해서 인벤토리에 추가
    /// </summary>
    public class ItemSelecter
    {
        // 템 랜덤 선택을 위해 일단 템 리스트 작성
        List<List<Item>> items = new List<List<Item>>(5)
        {
            new List<Item>(4){ new Ring(), new Necklace(), new Charm(),new Brooch() },
            new List<Item>(4){ new Helmet(), new Breastplate(), new Gloves(),new Shoes() },
            new List<Item>(4){ new Chicken(), new Stake(), new Fish(),new Salad() },
            new List<Item>(4){ new HealPotion(), new ManaPotion(), new ExpPotion(),new StrangePotion() },
            new List<Item>(4){ new Sword(), new Hammer(), new Spear(), new Axe()}
        };  
        public ItemSelecter(Inventory inventory)
        {
            EnterInventory(inventory); // 객체 생성하자마자 랜덤 아이템 객체 뽑고 인벤토리에 넣기
        }
        public void EnterInventory(Inventory inventory)
        {
            inventory.EnterInventory(SelectItem());
        }

        private Item SelectItem()
        {
            List<Item> type = items[Util.GetRandomNumber(0, 5)];
            return type[Util.GetRandomNumber(0, 4)];
        }
    }

}

