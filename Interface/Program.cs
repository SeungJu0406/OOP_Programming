namespace Interface
{
    public class Program
    {
        static void Main(string[] args)
        {
            Team<Character> members = new(8);
            members.AddTeam(new Hero("가로쉬", 4));
            members.AddTeam(new Minion("하늘빛비룡", 4, 4,members));
            members.PrintCharacter();
            Console.WriteLine();
            members.members[0].Attack(members.members[1]);
            Console.WriteLine();
            members.PrintCharacter();
        }
    }
}
