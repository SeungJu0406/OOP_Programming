using System.Xml.Linq;

namespace LevelTest2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Monster[] monsters  = new Monster[5];
            monsters[0] = new Pikachu();
            monsters[1] = new Charmander();
            monsters[2] = new Squirtle();
            monsters[3] = new Bulbasaur();
            monsters[4] = new Pikachu("노란 뚱땡이");

            foreach (Monster monster in monsters)
            {
                Console.WriteLine($"{monster.name} 공격해!");
                monster.Attack();
                Console.WriteLine();
            }


        }
    }
    public abstract class Monster
    { 
        Monster[] monsters;
        public string name {  get; set; }
        protected string skill {  get; set; }
        public abstract void Attack();
    }
    public class Pikachu : Monster 
    { 
        public Pikachu() 
        {
            this.name = "피카츄";
        }
        public Pikachu(string name) 
        {
            this.name =name;
        }
        public override void Attack()
        {
            Console.WriteLine($"{name}의 10만 볼트!");
        }
    }
    public class Charmander :Monster
    {
        public Charmander()
        {
            this.name = "파이리";
        }
        public Charmander(string name)
        {
            this.name = name;
        }
        public override void Attack()
        {
            Console.WriteLine($"{name}의 불꽃 세례!");
        }
    }
    public class Squirtle: Monster
    {
        public Squirtle()
        {
            this.name = "꼬부기";
        }
        public Squirtle(string name)
        {
            this.name = name;
        }
        public override void Attack()
        {
            Console.WriteLine($"{name}의 물대포!");
        }
    }
    public class Bulbasaur : Monster
    {
        public Bulbasaur()
        {
            this.name = "이상해씨";
        }
        public Bulbasaur(string name)
        {
            this.name = name;
        }
        public override void Attack()
        {
            Console.WriteLine($"{name}의 덩쿨 채찍!");
        }
    }

}
