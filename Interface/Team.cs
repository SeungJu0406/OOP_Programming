using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void Attack(IAttack attack)
        {
           
        }
        public void TakeDamage(ITakeDamage takeDamage)
        {
            
        }

        public void AddTeam(T member) // 하수인 추가 
        {
            if (index < members.Length)
                members[index++] = member;
        }

        public void RemoveTeam() // 하수인 사망
        {
            if (index > 0)
                members[--index] = null;
        }
        public void PrintCharacter()
        {
            Console.WriteLine("목록: ");
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
