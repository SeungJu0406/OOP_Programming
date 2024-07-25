namespace Delegate
{
    public class Program
    {
        public class Player
        {
            private Armor curArmor;
            public event Action OnHit;

            public void Equip(Armor armor)
            {
                Console.WriteLine($"플레이어가 {armor.name} 을/를 착용합니다.");
                curArmor = armor; // 현재 인스턴스 curArmor필드에 armor라는 Armor 인스턴스 객체 착용 : 캐릭터가 장비를 착용
            }

            public void UnEquip()
            {
                Console.WriteLine($"플레이어가 {curArmor.name} 을/를 해제합니다.");
                curArmor = null; // 현재 인스턴스 curArmor필드 비우기 : 캐릭터 장비 벗기
            }

            public void Hit()
            {
                Console.WriteLine("플레이어가 데미지를 받았습니다");
                if(OnHit != null) 
                {
                    OnHit(); // 나 맞아따!!!!!!!!!!! 
                }
            }
        }

        public class Armor
        {
            public string name;
            private int durability;

            public event Action OnBreaked;

            public Armor(string name, int durability)
            {
                this.name = name;
                this.durability = durability;
            }

            public void DecreaseDurability()
            {
                durability--; // 내구도 1 감소
                if (durability <= 0) // 내구도 0되면
                {
                    Break(); // 장비 파괴
                    return;
                }
                Console.WriteLine($"장비의 내구도가 닳습니다. 현재 내구도: {durability}");
            }

            private void Break()
            {
                if(OnBreaked != null)
                {
                    Console.WriteLine("장비가 파괴되었습니다.");
                    OnBreaked(); // 나 부숴져따!!!!!!!!!!
                }
            }
        }

        static void Main(string[] args)
        {
            Player player = new Player();
            Armor ammor = new Armor("갑옷", 3);
            player.OnHit += ammor.DecreaseDurability; // 맞으면 내구도 깎일게
            ammor.OnBreaked += player.UnEquip; // 부숴지면 벗을게

            player.Equip(ammor);
            player.Hit(); // 1대
            player.Hit(); // 2대
            player.Hit(); // 3대
        }
    }
}
