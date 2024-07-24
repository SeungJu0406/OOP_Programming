namespace Interface
{
    public class Program
    {
        static void Main(string[] args)
        {
            Team<Character> members = new(8);
            members.AddTeam(new Hero("제이나", 1));
            members.AddTeam(new Minion("하늘빛비룡", 4, 4));
            members.PrintCharacter();
            Console.WriteLine();
            members.members[1].Attack(members.members[0]);
            Console.WriteLine();
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
