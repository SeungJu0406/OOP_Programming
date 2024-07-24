namespace Generic
{
    public class Program
    {
        static void Main(string[] args)
        {
            Inventory<Item> potionInventory = new(10);
            potionInventory.Add(new Potion("체력 포션"));
            potionInventory.Add(new Potion("마나 포션"));
            potionInventory.Add(new Potion("경험치 포션"));
            potionInventory.Add(new Potion("활력포션"));
            potionInventory.Remove();
            potionInventory.Remove();
            potionInventory.PrintItemName();
        }
        
    }
    public abstract class Item // 인벤토리에 들어가는 Item 클래스
    {
        public string name { get; private set; } //필드 : 문자열 name
        public Item(string name) // name을 매개변수로 받는 생성자
        {
            this.name = name; // 매개변수를 받아 인스턴스의 name을 생성
        }
    }
    public class Potion : Item // Item 클래스를 상속받는 Potion 클래스
    {
        public Potion(string name) : base(name) { } // Potion 생성자 매개변수로 Item클래스 생성자의 매개변수를 가져온다
    }
    // T라는 일반화형을 넣어 여러가지 자료형에 관한 배열을 하나의 코드로 묶어서 표현한다
    public class Inventory<T> where T: Item // T에는 'Item' 을 상속받은 클래스만 넣을 수 있다
    {
        private T[] list; // 인벤토리를 담당할 배열 생성, 
        int index;  // 인벤토리 순서를 나타낼 정수형 변수
        public Inventory(int size) // 인벤토리 생성자, 매개변수로 size를 받는다. 생성자를 형성할때 <> 꺽쇠로 안에
        {
            this.list = new T[size]; // 해당 매개변수 size는 배열의 크기를 가리킨다
        }
        public void Add(T item) // Inventory 클래스에 위치한 Add함수 
        {
            if (index < list.Length)
            {
                list[index++] = item;               
            }
        }
        public void Remove()
        {
            if (index > 0)
            {
                list[--index] = null;
            }
        }
        public void PrintItemName()
        {
            Console.WriteLine("아이템 목록:");
            foreach(T item in list)
            {
                if (item != null) Console.WriteLine(item.name);
            }
        }

    }
}