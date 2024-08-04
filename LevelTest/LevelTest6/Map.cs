using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelTest6
{
    public class Map: IEnter
    {
        Road map;
        protected enum MapName { Town, Castle, Guild, Shop, Cenetry, Forest, Grassland, Sea, SIZE }
        public int id {  get; protected set; }
        public string name { get; protected set; }
        public bool isPlace;
        public void Enter(Player player)
        {
            isPlace = true;
            while (isPlace)
            {
                this.PrintPlace(player);
                this.WaitChoice(player);
            }
        }
        public virtual void PrintPlace(Player player) { isPlace = false; }
        public virtual void WaitChoice(Player player) { isPlace = false; }
        public virtual void EnterLobby() { }
    }
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


}
