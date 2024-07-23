namespace TrainerSystem
{
    public enum MobType { Electric, Fire, Water, Grass, NULL }
    public class Trainer
    {
        public Monster[] monsters;
        public Trainer()
        {
            monsters = new Monster[6];
            monsters[0] = new Pikachu(100, "지우피카츄");           
        }
        public void GetPokeMon(int level, MobType type, string name)
        {
            for (int i = 0; i < monsters.Length; i++)
            {
                if (monsters[i] == null)
                {
                    if (type == MobType.Electric) monsters[i] = new Pikachu(level, name);
                    if (type == MobType.Fire) monsters[i] = new Charmander(level, name);
                    if (type == MobType.Water) monsters[i] = new Squirtle(level, name);
                    if (type == MobType.Grass) monsters[i] = new Bulbasaur(level, name);
                    return;
                }
            }
            Console.WriteLine("포켓몬이 가득 찼습니다");
        }
        public void AllAttack()
        {
            foreach(Monster m in monsters)
            {
                if (m != null)
                {
                    (m as Pikachu)?.BaseAttack();
                    (m as Charmander)?.BaseAttack();
                    (m as Squirtle)?.BaseAttack();
                    (m as Bulbasaur)?.BaseAttack();
                }
            }
        }

    }
    public abstract class Monster
    {
        public int level;
        public MobType type;
        public string name;
        public abstract void BaseAttack();
    }
    public class Pikachu : Monster
    {
        public Pikachu(int level, string name)
        {
            this.level = level;
            this.type = MobType.Electric;
            this.name = name;
        }
        public override void BaseAttack()
        {
            Console.WriteLine("전광석화");
        }
    }
    public class Squirtle : Monster
    {
        public Squirtle(int level, string name)
        {
            this.level = level;
            this.type = MobType.Water;
            this.name = name;
        }
        public override void BaseAttack()
        {
            Console.WriteLine("물대포");
        }
    }
    public class Bulbasaur : Monster
    {
        public Bulbasaur(int level, string name)
        {
            this.level = level;
            this.type = MobType.Grass;
            this.name = name;
        }
        public override void BaseAttack()
        {
            Console.WriteLine("덩쿨채찍");
        }
    }
    public class Charmander : Monster
    {
        public Charmander(int level, string name)
        {
            this.level = level;
            this.type = MobType.Fire;
            this.name = name;
        }
        public override void BaseAttack()
        {
            Console.WriteLine("화염방사");
        }
    }
}
