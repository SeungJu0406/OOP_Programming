using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelTest4
{
    public class Town : Map
    {
        public Town()
        {
            id = (int)MapName.Town;
            name = "마을";
        }
    }
    public class Castle : Map
    {
        public Castle()
        {
            id = (int)MapName.Castle;
            name = "성";
        }
    }
    public class Guild : Map
    {
        public Guild()
        {
            id = (int)MapName.Guild;
            name = "길드";
        }
    }
    public class Shop : Map
    {
        public Shop()
        {
            id = (int)MapName.Shop;
            name = "상점";
        }
    }
    public class Cenetry : Map
    {
        public Cenetry()
        {
            id =(int)MapName.Cenetry;
            name = "묘지";
        }
    }
    public class Forest : Map
    {
        public Forest()
        {
            id = (int)MapName.Forest;
            name = "숲";
        }
    }
    public class Grassland : Map
    {
        public Grassland()
        {
            id = (int)MapName.Grassland;
            name = "초원";
        }
    }
    public class Sea : Map
    {
        public Sea()
        {
            id = (int)MapName.Sea;
            name = "바다";
        }
    }

}
