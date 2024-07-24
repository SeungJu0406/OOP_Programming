using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Character : ITakeDamage, IAttack, IDie
    {
        public string name; 
        public int power;
        public int hp;
        public Character(string name, int power)
        {
            this.name = name;
            this.power = power;
        }

        public void Attack(Character target)
        {
            if (power <= 0)
            {
                Console.WriteLine($"{name}은/는 {target.name}에게 공격할 수 없습니다");
                return;
            }
            Console.WriteLine($"{name}이/가 {target.name}에게 {power}만큼의 피해를 입혔습니다");
            target.TakeDamege(power);
        }

        public void TakeDamege(int power)
        {
            Console.WriteLine($"{name}이/가 {power}만큼의 피해를 입었습니다");
            hp -= power;
            if (hp <= 0)
            {
                hp = 0;
                Die();
                return;
            }
        }
        public virtual void Die()
        {
            Console.WriteLine($"{name}이 죽었습니다");            
        }
    }

    public class Hero : Character
    {
        public Hero(string name, int power) : base(name, power)
        {
            this.hp = 30;
        }
    }

    public class Minion : Character
    {
        public Minion(string name, int power, int hp, Team<Character> team) : base(name, power)
        {
            this.hp = hp;
            this.team = team;
        }
        public override void Die()
        {
            base.Die();
            team.RemoveTeam(this);          
        }
        private Team<Character> team; // Team<T>와 연동하기 위한 변수
    }
}
