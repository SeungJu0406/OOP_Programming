namespace ListAssignment3
{
    public class Program
    {
        static void Main(string[] args)
        {
                      
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
        public void Add(T element)
        {
            if (index > list.Length) 
            {
                list = AddList();
            }
            list[index++] = element;
            
        }
        public void AddList()
        {
            
        }
        public void Remove()
        {

        }
        public void RemoveAt()
        {

        }
        public void Clear()
        {

        }
    }
}
