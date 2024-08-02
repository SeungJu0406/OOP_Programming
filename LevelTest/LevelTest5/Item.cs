using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelTest5
{
    public class Item
    {
        public string name {  get; protected set; }
        public int price{ get; protected set; }
        public string description{ get; protected set; }
        public string effect{ get; protected set; }
    }
    public class PassiveItem: Item
    {

    }
    public class ActiveItem: Item
    {

    }
    public class Weapon :PassiveItem
    {
        public Weapon() 
        {
            name = "롱소드";
            price = 400;
            description = "기본적인 검";
            effect = "(소유) 공격력 상승";
        }
    }
    public class  Armor :PassiveItem
    {
        public Armor()
        {
            name = "천갑옷";
            price = 500;
            description = "얇은 갑옷";
            effect = "(소유) 방어력 상승";
        }
    }
    public class  Potion : ActiveItem
    {
        public Potion()
        {
            name = "이상한 포션";
            price = 800;
            description = "먹으면 기분이 안좋을 것 같다";
            effect = "(사용) 체력 영구상승 300";
        }
    }
}
