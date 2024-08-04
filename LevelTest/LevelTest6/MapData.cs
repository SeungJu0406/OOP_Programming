using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelTest6
{
    public class MapData: IEnter
    {
        Map map;
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
        public virtual void EnterLobby(Player player) { }
    }
    public class Town : MapData
    {
        public Town()
        {
            id = (int)MapName.Town;
            name = "마을";
        }
    }
    public class Castle : MapData
    {
        public Castle()
        {
            id = (int)MapName.Castle;
            name = "성";
        }
    }
    public class Guild : MapData
    {
        public Guild()
        {
            id = (int)MapName.Guild;
            name = "길드";
        }
    }

    public class Cenetry : MapData
    {
        public Cenetry()
        {
            id =(int)MapName.Cenetry;
            name = "묘지";
        }
    }
    public class Forest : MapData
    {
        public Forest()
        {
            id = (int)MapName.Forest;
            name = "숲";
        }
    }
    public class Grassland : MapData
    {
        public Grassland()
        {
            id = (int)MapName.Grassland;
            name = "초원";
        }
    }


}
