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
}