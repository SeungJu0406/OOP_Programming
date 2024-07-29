namespace ListAssignment4
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> myList = new();
            LinkedListNode<int> node1 = new LinkedListNode<int>(1);
            LinkedListNode<int> node2 = node1.AddNext(2);
            LinkedListNode<int> node3 = node2.AddNext(4);
            Console.WriteLine(node2.next.element);

        }
    }
    public class LinkedList<T>
    {
        LinkedList<T> list;
        LinkedListNode<T> first;
        LinkedListNode<T> last;
        public LinkedList()
        {
            first = null;
            list = this;
            last = null;
        }
        public void AddFisrt()
        {

        }
        public void AddLast(LinkedListNode<T> node,T element)
        {
           
        }

    }
    public class LinkedListNode<T>
    {
        public T element { get; set; }
        public LinkedListNode<T> next { get; set; }
        LinkedListNode<T> previois;
        public LinkedListNode(T node)
        {
            element = node;
            next = null;
            previois = null;
        }
        public LinkedListNode(T node, LinkedListNode<T> prev)
        {
            element = node;
            next = null;
            previois = prev;
        }
        public LinkedListNode<T> AddNext(T value)
        {
            next = new LinkedListNode<T>(value, this);
            return next;
        }
    } 
}
