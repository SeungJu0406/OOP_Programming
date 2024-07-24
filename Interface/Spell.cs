namespace Interface
{
    public class Spell // 전체 주문카드
    {
        int cost; // 필드: 비용
        public Spell()
        {
            this.cost = 1;
        }


    }
    public class AttackSpell : Spell, IAttack // 공격카드
    {
        protected int power; // 몇의 피해를 줄지
        public virtual void Attack(Character target) // 캐릭터를 공격
        {
            target.TakeDamege(power); 
        }
    }
    public class HealSpell : Spell, IHeal // 힐카드
    {
        public int healAmount; // 힐량이 몇인지
        public virtual void Heal(Character target, int healAmount) // 캐릭터에게 몇만큼 회복
        {
            target.Heal(target, healAmount);
        }
    }
    public class FireBall : AttackSpell // 화염구
    {
        string name;
        public FireBall() { this.name = "화염구"; this.power = 6; } // 생성 즉시 카드의 값이 정해짐
        public override void Attack(Character target) // 이건 없어도됨. 콘솔 출력을 위해 작성. 만약 추가 효가가 있는 카드면 이거로 추가효과 달면 될듯
        {
            Console.WriteLine($"{target.name}에게 {name}로 {power}의 피해를 입힙니다."); 
            base.Attack(target);
        }
    }
    public class InstantHeal : HealSpell // 순간치유
    {
        string name;
        public InstantHeal() { this.name = "순간 치유"; this.healAmount = 5; } // 생성즉시 순간치유 값 정해짐
        public override void Heal(Character target, int healAmount) // 단순 회복이라 없어도됨. 콘솔 출력을 위해 작성. 힐 외에도 추가효과가 있는 카드면 추가 효과 달면됨
        {
            Console.WriteLine($"{target.name}에게 {name}로 {healAmount}만큼의 힐을 줍니다");
            base.Heal(target , healAmount);
        }
    }
}