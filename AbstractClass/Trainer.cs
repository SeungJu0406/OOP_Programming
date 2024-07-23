namespace TrainerSystem
{
    public enum MobType { Electric, Fire, Water, Grass }
    public class Trainer
    {
        public Monster[] monsters;
        public Trainer()
        {
            monsters = new Monster[6];
            monsters[0] = new Pikachu(100, "삐까츄");
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
