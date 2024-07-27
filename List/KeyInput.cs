namespace ListAssignment
{
    /// <summary>
    /// 키 입력
    /// </summary>
    public class KeyInput
    {
        //이벤트 발생 키눌렀다
        public event Action OnPushKey0;
        public event Action<int> OnPushKey1;
        public void PushKey(Inventory inventory)
        {
            OnPushKey1 += inventory.ReadExitItem;
            OnPushKey0 += inventory.ReadyEnterItem;
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D0:
                case ConsoleKey.NumPad0:
                    OnPushKey0?.Invoke();
                   break;
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    OnPushKey1?.Invoke(1);
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    OnPushKey1?.Invoke(2);
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    OnPushKey1?.Invoke(3);
                    break;
                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    OnPushKey1?.Invoke(4);
                    break;
                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:
                    OnPushKey1?.Invoke(5);
                    break;
                case ConsoleKey.D6:
                case ConsoleKey.NumPad6:
                    OnPushKey1?.Invoke(6);
                    break;
                case ConsoleKey.D7:
                case ConsoleKey.NumPad7:
                    OnPushKey1?.Invoke(7);
                    break;
                case ConsoleKey.D8:
                case ConsoleKey.NumPad8:
                    OnPushKey1?.Invoke(8);
                    break;
                case ConsoleKey.D9:
                case ConsoleKey.NumPad9:
                    OnPushKey1?.Invoke(9);
                    break;
                default:
                    return;
            }
            OnPushKey0 -= inventory.ReadyEnterItem;
            OnPushKey1 -= inventory.ReadExitItem;
        }

    }
}
                    
                    
                    
                    
                    
                    
                    
                   
                    
                   
                    
                    
                    
                    
                    
                    
                    
                    