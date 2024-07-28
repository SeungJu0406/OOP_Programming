namespace ListAssignment3
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();
            for (int i = 0; i < 12; i++)
            {
                myList.Add(i+1);
            }
            myList.Remove(3);
            myList.RemoveAt(0);
            //myList.Clear();
            myList.PrintList();
        }
    }
    public class MyList<T>
    {
        T[] list;
        T[] temp;
        int index;
        public MyList()
        {
            index = 0;
            list = new T[10];
        }
        private MyList(MyList<T> list, int num)
        {
            this.index = list.index;
            this.list = new T[list.list.Length * num];
        }
        public void Add(T element)
        {
            if (index >= list.Length)
            {
                temp = list;
                this.list = new MyList<T>(this,2).list;
                for(int i = 0; i < temp.Length; i++)
                {
                    list[i] = temp[i];
                }
                Add(element);
                return;
            }
            list[index++] = element;
        }
        public void Remove(T element)
        {
            bool removeElement = false;
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i].Equals(element))
                {
                    removeElement = true;
                }
                if (removeElement)
                {
                    if (i + 1 >= list.Length)
                        break;
                    list[i] = list[i + 1];
                }
            }
            index--;
        }
        public void RemoveAt(int indexNum)
        {
            for (int i = indexNum; i < list.Length; i++)
            {
                if (i + 1 >= list.Length)
                    break;
                list[i] = list[i + 1];
            }
            index--;
        }
        public void Clear()
        {
            Array.Clear(list, 0, list.Length);
        }
        public void PrintList()
        {
            for(int i = 0;i < list.Length; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.WriteLine($"배열 총량: {list.Length}");
        }
    }
}
