using System.Xml.Linq;

namespace ListAssignment4
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> myList = new();
            myList.AddLast(1);
            myList.AddLast(2);
            myList.AddLast(3);
            myList.AddFirst(0);
            myList.AddFirst(6);
            myList.AddLast(7);
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
            }
            node = first.AddPrev(value);
            node.next = first; 
            first = first.previous;
        }
        public void AddLast(T value)
        {
            if(node == null)
            {
                node = new LinkedListNode<T>(value);
                last = node;
                first = last;
                return;
            }
            node = last.AddNext(value);
            node.previous= last;
            last = last.next;
        }
        public void PrintList()
        {
            FuncPrintList(first);
        }
        public LinkedListNode<T> FuncPrintList(LinkedListNode<T> node)
        {
            if (node == null)
                return null;
            Console.WriteLine($"{node.element}");
            return FuncPrintList(node.next);
        }
    }
    public class LinkedListNode<T>
    {
        public T element { get; set; }
        public LinkedListNode<T> next { get; set; }
        public LinkedListNode<T> previous { get; set; }
        public LinkedListNode(T node)
        {
            element = node;
            next = null;
            previous = null;
        }
        public LinkedListNode(T node, LinkedListNode<T> prev)
        {
            element = node;
            next = null;
            previous = prev;
        }
        public LinkedListNode(T node, LinkedListNode<T> next, int dummy)
        {
            element = node;
            next = next;
            previous = null;
        }
        public LinkedListNode<T> AddNext(T value)
        {
            next = new LinkedListNode<T>(value, this);
            return next;
        }
        public LinkedListNode<T> AddPrev(T value)
        {
            previous = new LinkedListNode<T>(value, this, 1);           
            return previous;
        }
    } 
}
