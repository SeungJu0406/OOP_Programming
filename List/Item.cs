using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ListAssignment
{
    public class Item
    {
        public string description { get; protected set; }
        public string name { get; protected set; }

        public void EnterInventory(Inventory inventory)
        {
            inventory.EnterInventory(this);
        }
        public void ExitInventory(Inventory inventory)
        {
            inventory.ExitInventory(this);
        }
        private Inventory inventory;
    }






}
