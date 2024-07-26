using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAssignment
{
    public class Armor : Item
    {
        public Armor()
        {

        }
    }
    public class Helmet : Armor
    {
        public Helmet()
        {
            this.name = "투구";
            description = "불편합니다";
        }
    }
    public class Breastplate : Armor
    {
        public Breastplate()
        {
            this.name = "갑빠";
            description = "불편합니다";
        }
    }
    public class Gloves : Armor
    {
        public Gloves()
        {
            this.name = "장갑";
            description = "불편합니다";
        }
    }
    public class Shoes : Armor
    {
        public Shoes()
        {
            this.name = "신발";
            description = "불편합니다";
        }
    }
}
