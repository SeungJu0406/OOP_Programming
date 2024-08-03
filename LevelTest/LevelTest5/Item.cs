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
        public int hp { get; protected set; }
        public int power { get; protected set; }
        public int defence { get; protected set; }
        public virtual void BeEffect(Player player) { }       
        public virtual void NotEffect(Player player) { }
    }
    public abstract class PassiveItem: Item
    {

    }
    public abstract class ActiveItem: Item
    {

    }
    public class Weapon :PassiveItem
    {      
        public Weapon() 
        {
            name = "롱소드";
            price = 400;
            description = "기본적인 검";
            power = 15;
            effect = $"(소유) 공격력 상승{power}";           
        }
        public override void BeEffect(Player player) 
        {
            player.power += power; 
        }
        public override void NotEffect(Player player)
        {
            player.power -= power;
        }
    }
    public class  Armor :PassiveItem
    {
        
        public Armor()
        {
            name = "천갑옷";
            price = 500;
            description = "얇은 갑옷";
            defence = 15;
            effect = $"(소유) 방어력 상승{defence}";
        }
        public override void BeEffect(Player player)
        {
            player.defense += defence;
        }
        public override void NotEffect(Player player)
        {
            player.defense -= defence;
        }
    }
    public class  Potion : ActiveItem
    {
        
        public Potion()
        {
            name = "이상한 포션";
            price = 800;
            description = "먹으면 기분이 안좋을 것 같다";
            hp = 300;
            effect = $"(사용) 체력 영구상승 {hp}";
        }
        public override void BeEffect(Player player)
        {
            player.hp += hp;
        }
        public override void NotEffect(Player player)
        {
            player.hp -= hp;
        }
    }
}
