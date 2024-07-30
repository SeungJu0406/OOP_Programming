using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAssignment
{
    /// <summary>
    /// 방어구
    /// </summary>
    public class Armor : Item
    {
        public Armor()
        {

        }
    }
    /// <summary>
    /// 투구
    /// </summary>
    public class Helmet : Armor
    {
        public Helmet()
        {
            this.name = "투구";
            description = "불편합니다";
        }
    }
    /// <summary>
    /// 흉갑
    /// </summary>
    public class Breastplate : Armor
    {
        public Breastplate()
        {
            this.name = "갑빠";
            description = "불편합니다";
        }
    }
    /// <summary>
    /// 장갑
    /// </summary>
    public class Gloves : Armor
    {
        public Gloves()
        {
            this.name = "장갑";
            description = "불편합니다";
        }
    }
    /// <summary>
    /// 신발
    /// </summary>
    public class Shoes : Armor
    {
        public Shoes()
        {
            this.name = "신발";
            description = "불편합니다";
        }
    }
}
