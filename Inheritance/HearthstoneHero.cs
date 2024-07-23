using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HearthstoneHero
{
    public abstract class Hero
    {
         protected int level;
         protected Name name;
         protected int hp;
         protected Job job;
        public enum Name { Jaina, Garroshi, Anduin, empty}
        public enum Job { Mage, Warrior, Priest, empty }
        public Hero(int level)
        {
            this.level = level;
            this.name=Name.empty;
            this.hp = 30;
            this.job= Job.empty;
        }
        public abstract void SpeakScript();
        public void HeroInfo()
        {
            Console.WriteLine($"레벨: {level}, 이름: {name}, 직업: {job}, 체력: {hp}");
        }
    }
    public class Jaina : Hero
    {
        public Jaina(int level):base(level) 
        {
            this.level =level;
            this.name = Name.Jaina;
            this.job = Job.Mage;
        }
        public override void SpeakScript() 
        {
            Console.WriteLine("후회하게 해 드리죠.");
        }
        
    }
    public class Garroshi : Hero
    {
        public Garroshi(int level) : base(level)
        {
            this.level = level;
            this.name = Name.Garroshi;
            this.job = Job.Warrior;
        }
        public override void SpeakScript()
        {
            Console.WriteLine("승리가 아니면 죽음을!");
        }

    }
    public class Anduin : Hero
    {
        public Anduin(int level) : base(level)
        {
            this.level = level;
            this.name = Name.Anduin;
            this.job = Job.Priest;
        }
        public override void SpeakScript()
        {
            Console.WriteLine("빛이 당신을 태울 것 입니다!");
        }

    }
}
