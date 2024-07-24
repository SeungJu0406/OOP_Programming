using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface IAttack
    {
        void Attack(Character target);
    }
    public interface ITakeDamage
    {
        void TakeDamege(int power);
    }
    public interface IDie
    {
        void Die();
    }
    public interface ICounter
    {
        void Counter(Character attacker);
    }
}
