using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface IAttack //공격
    {
        void Attack(Character target);
    }
    public interface ITakeDamage //피격
    {
        void TakeDamege(int power);
    }
    public interface IDie // 죽음
    {
        void Die();
    }
    public interface ICounter //반격
    {
        void Counter(Character attacker);
    }
    public interface IHeal //힐
    {
        void Heal(Character character,int healAmount);
    }
}
