namespace Interface
{
    public class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public class Team<T> where T: Character
    {
        T[] members;
        int index;
        public Team(int size) 
        {
            index = 0;
            members = new T[size];
        }

        public void AddTeam(T member) // 하수인 추가 
        {
            if (index < members.Length)
                members[index++] = member;
        }

        public void RemoveTeam(T member) // 하수인 사망
        {
            if (index > 0)
                members[--index] = member;
        }
    }
    public class Character : ITakeDamage, IAttack, IDie
    {
        string name;
        int power;
        int hp;
        public Character(string name, int power, int hp)
        {
            this.name = name;
            this.power = power;
            this.hp = hp;
        }

        public void Attack(Character target, int power)
        {
            Console.WriteLine($"{target}에게 {power}만큼의 피해를 입혔습니다");
            target.TakeDamege(power);
        }

        public void TakeDamege(int power)
        {
            Console.WriteLine($"{power}만큼의 피해를 입었습니다");
            hp -= power;
            if (hp < 0)
            {
                hp = 0;
                Die();
                return;
            }
            Console.WriteLine($"{power}만큼의 피해를 입었습니다");
        }
        public void Die(Character target)
        {
            Console.WriteLine($"{target}이 죽었습니다");
        }
    }
    public class Hero : Character
    {
        public Hero(string name, int power,int hp) : base(name, power, hp) { }
    }
    public class Minion : Character
    {
        bool isSleep;
        public Minion(string name, int power, int hp) : base(name, power, hp) { }
    }
    public interface IAttack
    {
        void Attack(Character target, int power);
    }
    public interface ITakeDamage
    {
        void TakeDamege(int power);
    }
    public interface IDie
    {
        void Die(Character character);
    }
}
