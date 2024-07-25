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
                curArmor.OnBreaked += UnEquip; // 장비 부숴졌을 때 벗을게
            }

            public void UnEquip()
            {
                Console.WriteLine($"플레이어가 {curArmor.name} 을/를 해제합니다.");
                curArmor.OnBreaked -= UnEquip; // 벗었으니 벗는 함수 뺄게
                curArmor = null; // 현재 인스턴스 curArmor필드 비우기 : 캐릭터 장비 벗기           
            }

            public void Hit()
            {
                Console.WriteLine("플레이어가 데미지를 받았습니다");
                if (curArmor == null) // 부숴질 장비 객체가 없기때문에 함수를 끊는다
                    return;
                this.OnHit += curArmor.DecreaseDurability; // 맞았으니 내구도 깎일게
                OnHit?.Invoke(); // 나 마자따!!!!!!!!!!!!!!!
            }
        }

        public class Armor
        {
            public string name;
            private int durability;
            Player player;

            public event Action OnBreaked;

            public Armor(string name, int durability, Player player)
            {
                this.name = name;
                this.durability = durability;
                this.player = player;
            }

            public void DecreaseDurability()
            {
                player.OnHit -= DecreaseDurability; // 맞았으니 그만 맞을게
                if (durability <= 0)
                    return;
                durability--; // 내구도 1 감소
                if (durability <= 0) // 내구도 0되면
                {
                    Break(); // 장비 파괴
                    return;
                }
                Console.WriteLine($"{name}의 내구도가 닳습니다. 현재 내구도: {durability}");              
            }

            private void Break()
            {
                Console.WriteLine("장비가 파괴되었습니다.");
                OnBreaked?.Invoke(); // 나 부숴져따!!!!!!!!!!!!
            }
        }

        static void Main(string[] args)
        {
            Player player = new Player();
            Armor ammor = new Armor("갑옷", 3, player);

            player.Equip(ammor);
            player.Hit(); // 1대
            player.Hit(); // 2대
            player.Hit(); // 3대
            player.Hit();
        }
    }
}
