using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAssignment4
{
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
