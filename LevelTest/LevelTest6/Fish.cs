using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelTest6
{
    public class Fish : ActiveItem
    {
    }
    public class Mackerel : Fish
    {
        public Mackerel()
        {
            name = "고등어";
            price = 100;
            description = "싱싱한 고등어";
            hp = 50;
            effect = $"(소비) 체력 {hp} 증가";
        }
     }
    public class Squid : Fish
    {
        public Squid() 
        {
            name = "오징어";
            price = 100;
            description = "무쌩긴 오징어";
            power = 2;
            effect = $"(소비) 공격력 {power} 증가";
        }
    } 
    public class Bass : Fish
    {
        public Bass()
        {
            name = "농어";
            price = 200;
            description = "싱싱한 농어";
            defence = 5;
            effect = $"(소비) 방어력 {defence} 증가";
        }
    }
}
