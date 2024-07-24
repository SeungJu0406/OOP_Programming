namespace Interface
{
    public class Program
    {
        static void Main(string[] args)
        {
            Team<Character> members = new(8);
            members.AddTeam(new Hero("가로쉬", 4)); // 0
            members.AddTeam(new Minion("꿀주먹 오우거", 6, 7,members)); // 1
            members.AddTeam(new Minion("단검 곡예사", 3, 2, members)); // 2
            members.AddTeam(new Minion("볼바르 폴드라곤", 1, 7, members)); // 3
            members.AddTeam(new Minion("방패병", 0, 4, members)); // 4
            members.AddTeam(new Minion("박사 붐", 7, 7, members)); // 5
            members.AddTeam(new BattleCryMinion("리로이 젠킨스", 6, 2,"적에게 새끼용 두마리를 소환합니다",members)); // 6
            members.AddTeam(new BattleCryMinion("바위언덕 수호병", 1, 5,"도발 하수인을 발견합니다" ,members)); // 7
            members.AddTeam(new Minion("용암 거인", 8, 8, members)); // 8
            Console.WriteLine();
            members.members[4].Attack(members.members[1]);
            Console.WriteLine();
            members.members[6].Attack(members.members[5]);
            Console.WriteLine();
            members.members[0].Attack(members.members[4]);
            Console.WriteLine();
            members.members[5].Attack(members.members[1]);
            Console.WriteLine();
            members.members[7].Attack(members.members[3]);
            Console.WriteLine();
            members.PrintCharacter();
        }
    }
}
