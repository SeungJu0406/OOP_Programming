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
                curArmor = armor;
            }

            public void UnEquip()
            {
                Console.WriteLine($"플레이어가 {curArmor.name} 을/를 해제합니다.");
                curArmor = null;
            }

            public void Hit()
            {
                Console.WriteLine("플레이어가 데미지를 받았습니다");
                if(OnHit != null)
                {
                    OnHit();
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
                durability--;               
                if (durability <= 0)
                {
                    Break();
                    return;
                }
                Console.WriteLine($"장비의 내구도가 닳습니다. 현재 내구도: {durability}");
            }

            private void Break()
            {
                if(OnBreaked != null)
                {
                    Console.WriteLine("장비가 파괴되었습니다.");
                    OnBreaked();
                }
            }
        }

        static void Main(string[] args)
        {
            Player player = new Player();
            Armor ammor = new Armor("갑옷", 3);

            player.Equip(ammor);
            player.OnHit += ammor.DecreaseDurability;
            ammor.OnBreaked += player.UnEquip;
            player.Hit();
            player.Hit();
            player.Hit();
        }
    }
}
