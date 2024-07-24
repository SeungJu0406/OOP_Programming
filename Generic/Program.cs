namespace Generic
{
    public class Program
    {
        static void Main(string[] args)
        {
            Inventory<Item> potionInventory = new(10); // Inventory 객체 생성, 생성자로 10칸짜리 인벤토리(크기가 10인 배열)를 생성한다
            potionInventory.Add(new Potion("체력 포션"));
            potionInventory.Add(new Potion("마나 포션"));
            potionInventory.Add(new Potion("경험치 포션"));
            potionInventory.Add(new Potion("활력포션"));// Add 함수로 Potion 인스턴스를 만든다. 인스턴스는 생성자로 name의 필드를 가진다 
            potionInventory.Remove(); // Remove함수로 가장 마지막에 입력되었던 인스턴스가 null이 된다. 지금의 경우 "활력포션"의 Potion 인스턴스가 비워진다
            potionInventory.Remove(); // Remove함수로 가장 마지막에 입력되었던 인스턴스가 null이 된다. 지금의 경우 "경험치 포션"의 Potion 인스턴스가 비워진다
            potionInventory.PrintItemName(); // PrintItemName함수로 현재 배열에 저장된 Potion 인스턴스의 name이 출력이 된다. 배열 10칸중 null은 출력되지 않는다
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
    public class Inventory<T> where T : Item // T에는 'Item' 을 상속받은 클래스만 넣을 수 있다
    {
        private T[] list; // 인벤토리를 담당할 배열 생성, 
        int index;  // 인벤토리 순서를 나타낼 정수형 변수
        public Inventory(int size) // 인벤토리 생성자, 매개변수로 size를 받는다. 생성자를 형성할때 <> 꺽쇠로 안에
        {
            this.list = new T[size]; // 해당 매개변수 size는 배열의 크기를 가리킨다
        }
        public void Add(T item) // Inventory 클래스에 위치한 Add함수. 인벤토리에 아이템을 채우는 함수이다. 매개변수로 T형 item 변수, 즉 Item형 인스턴스를 받는다. 
        {
            if (index < list.Length) // 배열의 크기가 index, 즉 현재 순서보다 클 때
            {
                list[index++] = item; // 해당 배열에 인스턴스 추가후 순서를 1 늘린다
            }
        }
        public void Remove() // Inventory 클래스에 위치한 Remove함수. 인벤토리에 아이템을 비우는 함수이다
        {
            if (index > 0) // 순서가 0보다 클때만 작동, 0보다 작은 경우에서 인벤토리를 비울 수 없기 때문
            {
                list[--index] = null; // 해당 배열을 null로 바꾼 후 순서를 1 줄인다
            }
        }
        public void PrintItemName() // Inventory 클래스에 위치한 PrintItemName함수. list배열: 인벤토리 칸을 돌면서 아이템 목록을 출력한다
        {
            {
                Console.WriteLine("아이템 목록:"); // 콘솔에 "아이템 목록" 출력
                foreach (T item in list) // list 배열의 Item 인스턴스들을 하나씩 반복한다 
                {
                    if (item != null) Console.WriteLine(item.name); // 만약 해당 인스턴스가 null, 비어있지 않을때. 해당 인스턴스의 name을 출력한다
                }
            }

        }
    }
}