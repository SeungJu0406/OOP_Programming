namespace Interface
{
    public class Character : ITakeDamage, IAttack, IDie, IHeal
    {
        public string name;
        public int power;
        public int maxHp;
        public int hp;
        public Character(string name, int power)
        {
            this.name = name;
            this.power = power;            
        }

        public void Attack(Character target) // 공격 함수
        {
            if (power <= 0)
            {
                Console.WriteLine($"{name}은/는 {target.name}에게 공격할 수 없습니다");
                return;
            }
            Console.WriteLine($"{name}이/가 {target.name}에게 {power}만큼의 피해를 입혔습니다.");
            target.TakeDamege(power);
            TakeDamege(target.power);
        }

        public void TakeDamege(int power) // 피격으로 인한 데미지 받기
        {
            hp -= power;
            if (hp <= 0)
            {
                hp = 0;
                Die();
                return;
            }
        }
        public void Heal(Character character ,int healAmount)
        {
            character.hp += healAmount;
            if (character.hp > character.maxHp)
                character.hp = character.maxHp; 
        }
        public virtual void Die() // 죽음 
        {
            Console.WriteLine($"{name}이 죽었습니다");
        }
    }

    public class Hero : Character
    {
        public Hero(string name, int power) : base(name, power)
        {
            this.maxHp = 30;
            this.hp = maxHp;
        }
    }

    public class Minion : Character
    {
        public Minion(string name, int power, int maxhp, Team<Character> team) : base(name, power)
        {
            this.maxHp = maxhp;
            this.team = team;
            this.hp = maxHp;
        }
        public override void Die() // 하수인이 죽은경우 필드에서 파괴됨을 나타내야됨
        {
            base.Die();
            team.RemoveTeam(this);
        }
        private Team<Character> team; // Team<T>와 연동하기 위한 변수
    }

    public class BattleCryMinion : Minion // 전투의 함성 하수인
    {
        public BattleCryMinion(string name, int power, int hp, string description, Team<Character> team) : base(name, power, hp, team)
        {
            this.battleCry = description;
            Battlecry(); //전함 하수인은 선언 시에 효과가 바로 출력된다
        }
        public void Battlecry() // 전함 효과
        {
            Console.WriteLine($"{name}의 전투의 함성 효과: {battleCry} ");
        }
        private string battleCry;
    }
    public class DeathrattleMinion : Minion // 죽음의 메아리 하수인
    {
        public DeathrattleMinion(string name, int power, int hp, string description, Team<Character> team) : base(name, power, hp, team)
        {
            this.deathRattle = description;
        }
        public override void Die() // 죽메 효과
        {
            base .Die();
            Console.WriteLine($"{name}의 죽음의 메아리:{deathRattle}");
        }
        private string deathRattle;
    }
}
