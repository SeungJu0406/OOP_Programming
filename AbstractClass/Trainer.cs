namespace TrainerSystem
{
    public enum MobType { Electric, Fire, Water, Grass }
    public class Trainer
    {
        public Monster[] monsters;       
        public Trainer()
        {
            index = 1;
            monsters = new Monster[6];
            monsters[0] = new Pikachu(100, "삐까츄");
        }
        public void GetPokeMon(int level,MobType type ,string name)
        {
            if (index == 6)
            {
                Console.WriteLine("포켓몬이 가득 찼습니다");
                return;
            }
            if (type == MobType.Electric) monsters[index++]=new Pikachu(level, name);
            if (type == MobType.Fire) monsters[index++]=new Charmander(level, name);
            if (type == MobType.Water) monsters[index++] = new Squirtle(level, name);
            if (type == MobType.Grass) monsters[index++] = new Bulbasaur(level, name); 
        }
        int index;
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
