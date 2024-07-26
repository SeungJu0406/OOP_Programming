using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAssignment
{
    public class Weapon : Item
    {
        public Weapon()
        {

        }
    }

    public class Sword : Weapon
    {
        public Sword()
        {
            this.name = "검";
            description = "아픕니다";
        }
    }
    public class Hammer : Weapon     
    {
        public Hammer() 
        {
            this.name = "망치";
            description = "무겁습니다";
        }
    }

    public class Spear : Weapon
    {
        public Spear()
        {
            this.name = "창";
            description = "길쭉합니다";
        }
    }
    public class Axe : Weapon
    {
        public Axe()
        {
            this.name = "도끼";
            description = "짱쎕니다";
        }
    }
}
