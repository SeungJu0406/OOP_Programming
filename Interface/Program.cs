namespace Interface
{
    public class Program
    {
        static void Main(string[] args)
        {
            Team<Character> members = new(8);
            members.AddTeam(new Hero("가로쉬", 4)); // 0
            members.AddTeam(new Minion("하늘빛 비룡", 4, 4,members)); // 1
            members.AddTeam(new Minion("단검 곡예사", 3, 2, members)); // 2
            members.AddTeam(new Minion("험상궃은 손님", 3, 3, members)); // 3
            members.AddTeam(new Minion("방패병", 0, 4, members)); // 4
            members.AddTeam(new Minion("박사 붐", 7, 7, members)); // 5
            members.AddTeam(new Minion("리로이 젠킨스", 6, 2, members)); // 6
            members.AddTeam(new Minion("위습", 1, 1, members)); // 7
            members.AddTeam(new Minion("용암 거인", 8, 8, members)); // 8
            Console.WriteLine();
            members.members[4].Attack(members.members[1]);
            members.members[6].Attack(members.members[5]);
            members.members[0].Attack(members.members[4]);
            members.members[5].Attack(members.members[1]);
            Console.WriteLine();
            members.PrintCharacter();
        }
    }
}
