namespace Interface
{
    public class Spell
    {
        int cost;
        public Spell()
        {
            this.cost = 1;
        }


    }
    public class AttackSpell : Spell, IAttack
    {
        protected int power;
        public AttackSpell()
        {
        }

        public virtual void Attack(Character target)
        {
            target.TakeDamege(power);
        }
    }
    public class HealSpell : Spell, IHeal
    {
        public int healAmount;
        public virtual void Heal(Character target, int healAmount)
        {
            target.Heal(target, healAmount);
        }
    }
    public class FireBall : AttackSpell
    {
        string name;
        public FireBall() { this.name = "화염구"; this.power = 6; }
        public override void Attack(Character target)
        {
            Console.WriteLine($"{target.name}에게 {name}로 {power}의 피해를 입힙니다.");
            base.Attack(target);
        }
    }
    public class InstantHeal : HealSpell
    {
        string name;
        public InstantHeal() { this.name = "순간 치유"; this.healAmount = 5; }
        public override void Heal(Character target, int healAmount)
        {
            Console.WriteLine($"{target.name}에게 {name}로 {healAmount}만큼의 힐을 줍니다");
            base.Heal(target , healAmount);
        }
    }
}