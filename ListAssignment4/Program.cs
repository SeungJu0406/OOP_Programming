namespace ListAssignment4
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> myList = new();                    
            myList.AddLast(1);
            myList.AddLast(2);
            myList.AddFirst(0);
            myList.AddLast(3);
            myList.AddLast(4);
            myList.AddLast(5);
            //myList.RemoveFirst();
            //myList.RemoveLast();
            //myList.Remove(2);
            //myList.Clear();
            myList.PrintList();
        }
    }
    public class LinkedList<T>
    {
        public LinkedList<T> list { get; set; }
        public LinkedListNode<T> first { get; set; }
        public LinkedListNode<T> last { get; set; }
        public LinkedListNode<T> node { get; set; }
        public LinkedList()
        {
            list = this;
            first = null;
            last = null;
            node = null;
        }

        public void AddFirst(T value)
        {
            if (node == null)
            {
                node = new LinkedListNode<T>(value);
                last = node;
                first = last;
                return;
            }
            node = first.AddPrev(value);
            node.next = first;
            first = first.previous;
        }

        public void AddLast(T value)
        {
            if (node == null)
            {
                node = new LinkedListNode<T>(value);
                last = node;
                first = last;
                return;
            }
            node = last.AddNext(value);
            node.previous = last;
            last = last.next;
        }

        public void RemoveFirst()
        {
            first = first.next;
            first.previous = null;
        }

        public void RemoveLast()
        {            
            last = last.previous;
            last.next = null;
        }

        public void Remove(T value)
        {
            node = first;
            while(!(node.element.Equals(value)))
            {
                node = node.next;
            }
            node.previous.next = node.next;
            node.next.previous = node.previous;
            node = null;
        }

        public void Clear()
        {
            while(first != last)
            {
                first = first.next;
                first.previous= null;
            }
            first = null;
        }

        public void PrintList()
        {
            FuncPrintList(first);
        }
        private LinkedListNode<T> FuncPrintList(LinkedListNode<T> node)
        {
            if (node == null)
                return null;
            Console.WriteLine($"{node.element}");
            return FuncPrintList(node.next);
        }
    }
    
}
