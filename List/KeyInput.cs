namespace ListAssignment
{
    public class KeyInput
    {
        //키 입력
        //이벤트 발생 키눌렀다
        //지정자를 써보자
        public event Action OnPushKey0;

        public void PushKey(Inventory inventory)
        {
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D0:
                    OnPushKey0 += inventory.ReadyEnterItem;
                    OnPushKey0?.Invoke();
                    OnPushKey0 -= inventory.ReadyEnterItem;
                    break;
                default:
                    return;
            }

        }

    }
}