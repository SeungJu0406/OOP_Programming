using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAssignment
{
    public class KeyInput : IPushKey
    {
        //키 입력
        //이벤트 발생 키눌렀다
        //지정자를 써보자
        public event Func<Item> OnPushKey0;

        public void PushKey()
        {          
            
        }

        public void PushKey0()
        {

        }
        private ItemSelecter itemSelecter;
    }
}
