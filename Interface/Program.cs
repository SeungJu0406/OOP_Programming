namespace Interface
{
    public class Program
    {
        static void Main(string[] args)
        {
            Team<Character> members = new(8);
            members.AddTeam(new Hero("제이나", 1));
            members.AddTeam(new Minion("하늘빛비룡", 4, 1));
            members.PrintCharacter();
            members.members[0].Attack(members.members[1]);
            members.PrintCharacter();
        }
    }
    
    
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
}
