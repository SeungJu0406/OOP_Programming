using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAssignment
{
    public class KeyInput
    {
        //키 입력
        //이벤트 발생 키눌렀다
        public Action OnKey1;
        public Action OnKey2;
        public Action OnKey3;
        public Action OnKey4;
        public Action OnKey5;
        public Action OnKey6;
        public Action OnKey7;
        public Action OnKey8; 
        public Action OnKey9;
        public Action OnKey0;
        public void PushKey0()
        {
            itemSelecter.SelectItem();
            OnKey0?.Invoke();
        }
        private ItemSelecter itemSelecter;
    }
}
