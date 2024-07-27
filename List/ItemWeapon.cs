using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAssignment
{
    /// <summary>
    /// 무기
    /// </summary>
    public class Weapon : Item
    {
        public Weapon()
        {

        }
    }
    /// <summary>
    /// 검
    /// </summary>
    public class Sword : Weapon
    {
        public Sword()
        {
            this.name = "검";
            description = "아픕니다";
        }
    }
    /// <summary>
    /// 망치
    /// </summary>
    public class Hammer : Weapon     
    {
        public Hammer() 
        {
            this.name = "망치";
            description = "무겁습니다";
        }
    }
    /// <summary>
    /// 창
    /// </summary>
    public class Spear : Weapon
    {
        public Spear()
        {
            this.name = "창";
            description = "길쭉합니다";
        }
    }
    /// <summary>
    /// 도끼
    /// </summary>
    public class Axe : Weapon
    {
        public Axe()
        {
            this.name = "도끼";
            description = "짱쎕니다";
        }
    }
}
