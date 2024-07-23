using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HearthstoneCard
{
    public abstract class Card
    {
        protected enum Name { Shieldbearer, AzureDrake, MoltenGiant, LeeroyJenkins }
        protected enum Rarity {Common,Rare, Epic, Legendary}
        protected Name name;
        protected int power;
        protected int hp;
        protected int cost;
        protected Rarity rarity;
        protected bool isGoldenCard;
        public Card()
        {
            bool isGoldenCard = false;
        }
        public abstract void PrintEffect();
        public virtual void PrintGoldenEffect()
        {
            Console.WriteLine("일반카드입니다. 빛나지 않습니다");
        }
        public void CardInfo()
        {
            Console.WriteLine($"{name}: {cost}코 {power}/{hp}  {rarity}카드.");
        }

    }
    public class Shieldbearer : Card
    {
        public Shieldbearer()
        {
            name = Name.Shieldbearer;
            power = 0;
            hp = 4;
            cost = 1;
            rarity = Rarity.Common;
        }
        public override void PrintEffect()
        {
            Console.WriteLine("카드가 빛나지 않습니다");
        }
    }
    public class AzureDrake : Card
    {
        public AzureDrake()
        {
            name = Name.AzureDrake;
            power = 4;
            hp = 4;
            cost = 5;
            rarity = Rarity.Rare;
        }
        public override void PrintEffect()
        {
            Console.WriteLine("카드가 파란색으로 빛납니다");
        }
    }
    public class MoltenGiant : Card
    {
        public MoltenGiant()
        {
            name = Name.MoltenGiant;
            power = 8;
            hp = 8;
            cost = 20;
            rarity = Rarity.Epic;
        }
        public override void PrintEffect()
        {
            Console.WriteLine("카드가 보라색으로 빛납니다...!!!");
        }
    }
    public class LeeroyJenkins : Card
    {
        public LeeroyJenkins()
        {
            name = Name.LeeroyJenkins;
            power = 6;
            hp = 2;
            cost = 5;
            rarity = Rarity.Legendary;
            isGoldenCard = true;
        }
        public override void PrintEffect()
        {
            Console.WriteLine("카드가!!!!!!! 황금색으로!!!!!! 빛납니다!!!!!!");
        }
        public override void PrintGoldenEffect()
        {
            Console.WriteLine("황금카드입니다. 매우매우 반짝반짝 빛나며, 일러스트가 움직입니다.");
        }
    }

}
