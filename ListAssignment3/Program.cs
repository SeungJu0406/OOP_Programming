namespace ListAssignment3
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();
            for (int i = 0; i < 8; i++)
            {
                myList.Add(i);
            }
            myList.Remove(4);
            myList.Remove(5);
            myList.PrintList();
        }
    }
    public class MyList<T>
    {
        T[] list;
        int index;
        public MyList()
        {
            index = 0;
            list = new T[10];
        }
        private MyList(MyList<T> list)
        {
            this.index = list.index;
            this.list = new T[list.list.Length * 2];
        }
        public void Add(T element)
        {
            if (index > list.Length)
            {
                this.list = new MyList<T>(this).list;
            }
            list[index++] = element;
        }
        public void Remove(T element)
        {
            T temp;
            bool removeElement = false;
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i].Equals(element))
                {
                    removeElement = true;
                }
                if (removeElement)
                {
                    if (i+1>=list.Length)
                        break;
                    list[i] = list[i + 1];
                }
               
            }
            index--;
        }
        public void RemoveAt()
        {

        }
        public void Clear()
        {

        }
        public void PrintList()
        {
            foreach (T element in list)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine($"배열 총량: {list.Length}");
        }
    }
}    
