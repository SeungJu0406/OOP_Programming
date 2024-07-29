using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAssignment
{
    /// <summary>
    /// 포션
    /// </summary>
    public class Potion : Item
    {
        public Potion()
        {

        }
    }
    /// <summary>
    /// 힐포션
    /// </summary>
    public class HealPotion : Potion
    {
        public HealPotion()
        {
            this.name= "힐포션";
            description = "체력을 회복합니다";
        }
    }
    /// <summary>
    /// 마나포션
    /// </summary>
    public class ManaPotion : Potion 
    {
        public ManaPotion()
        {
            this.name = "마나포션";
            description = "마나를 회복합니다";
        }
    }
    /// <summary>
    /// 경험치포션
    /// </summary>
    public class ExpPotion : Potion 
    {
        public ExpPotion()
        {
            this.name = "경험치포션";
            description = "경험치를 소량 얻습니다";
        }
    }
    /// <summary>
    /// 이상한포션
    /// </summary>
    public class StrangePotion : Potion 
    {
        public StrangePotion()
        {
            this.name = "이상한포션";
            description = "배가 아픕니다";
        }
    }

}
