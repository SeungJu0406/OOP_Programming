namespace Interface
{
    public class Team<T> where T : Character
    {
        public T[] members;
        int index;
        public Team(int size)
        {
            int index = 0;
            members = new T[size];
        }

        public void AddTeam(T member) // 하수인 추가 
        {
            if (index < members.Length)
                members[index++] = member;
        }

        public void RemoveTeam(T character) // 하수인 사망
        {
            for (int i = 0; i < members.Length; i++)
            {
                if (members[i] == character)
                {
                    Console.WriteLine($"{members[i].name}이 파괴됩니다.");
                    members[i] = null;
                    return;
                }
            }
        }
        public void PrintCharacter()
        {
            foreach (T member in members)
            {
                if (member != null)
                {
                    Console.WriteLine($"{member.name}: {member.power}/{member.hp}");
                }
            }
        }
    }
}
