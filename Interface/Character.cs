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
        public void Die()
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
        bool isSleep;
        public Minion(string name, int power, int hp) : base(name, power)
        {
            this.hp = hp;
        }
    }
}
