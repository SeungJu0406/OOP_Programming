using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAssignment
{
    public class GameMannager
    {
        public GameMannager() 
        {
            #region 키 입력
            keyInput.OnKey0 += item.EnterInventory(inventory);
            #endregion
        }
        private KeyInput keyInput {  get; set; }
        private Item item { get; set; }
        private Inventory inventory { get; set; }
    }
}
