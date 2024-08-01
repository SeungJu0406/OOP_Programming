namespace QueueAssignment2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Dequeue(); 
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            for (int i = 1; i< 10; i++)
            {
                queue.Enqueue(i);
            }
            //for (int i = 10; i < 18; i++)
            //{
            ////    queue.Enqueue(i);
            ////}
            Console.WriteLine();
            queue.PrintQueue();
            Console.WriteLine();
            Console.WriteLine(queue.Peek());
            Console.WriteLine();
            queue.Clear();
            queue.Enqueue(1);
            queue.PrintQueue();
        }
    }
    public class Queue<T>
    {
        T[] queue;
        T[] temp;
        int head;
        int tail;
        public Queue()
        {
            queue = new T[10];
            head = 0;
            tail = 0;
        }
        public Queue(Queue<T> pastQueue)
        {
            queue = new T[pastQueue.queue.Length*2];           
        }
        public void Enqueue(T value)
        {
            queue[tail++] = value;
            if (tail>= queue.Length)
            {
                tail = 0;
            }
            if (((head == 0) && (tail == queue.Length - 1)) || tail == head)
            {
                int intTemp= head;
                temp = queue;
                queue = new Queue<T>(this).queue;
                for (int i = head; i < temp.Length; i++)
                {
                    queue[i - head] = temp[i];
                }
                for (int i = 0; i < head; i++)
                {
                    queue[temp.Length - intTemp-- ] = temp[i];
                }
                this.head = 0;
                this.tail = temp.Length - 1;
                return;
            }
        }
        public void Dequeue()
        {
            if (head >= queue.Length)
                head = 0;
            queue[head++] = default(T);
        }
        public T Peek()
        {
            return queue[head];
        }
        public void Clear()
        {
            Array.Clear(queue, 0, queue.Length);
            head = 0;
            tail = 0;
        }
        public void PrintQueue()
        {
            foreach (T i in queue)
            {
               Console.WriteLine(i);
            }
        }
    }
}
