using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAssignment
{
    public class GameManager
    {
        public void InitializeGameObject()
        {
            Inventory inventory = new Inventory();
            KeyInput keyInput = new KeyInput();
            ItemSelecter itemSelecter = new ItemSelecter();
            Item item = new Item();
        }
    }
}
