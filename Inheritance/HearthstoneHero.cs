using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HearthstoneHero
{
    public class Hero
    {
        Name name;
        int hp;
        Job job;
        public enum Name { 제이나, 가로쉬, 안두인, empty}
        public enum Job{마법사, 전사, 사제, empty }
        public Hero()
        {
            this.name=Name.empty;
            this.hp = 30;

        }

    }
}
