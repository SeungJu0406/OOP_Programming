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
            Console.WriteLine(queue.Peek());
            queue.Dequeue();
            Console.WriteLine(queue.Peek());
            queue.Enqueue(5);
            queue.Enqueue(5);
            queue.Enqueue(5);
            queue.Enqueue(5);
            queue.Enqueue(5);
            queue.Enqueue(5);
            queue.Enqueue(5);
            //queue.PrintQueue();
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
            queue[head]=default(T);
        }
        public Queue(int pastIndex, Queue<T> pastQueue)
        {
            queue = new T[pastQueue.queue.Length*2];
            head = 0;
            tail = pastIndex-1;
        }
        public void Enqueue(T value)
        {
            if(tail>= queue.Length)
            {
                tail = 0;
            }
            if (((head == 0) && (tail == queue.Length - 1)) || tail == head && queue[head] == null  )
            {
                temp = queue;
                queue = new Queue<T>(queue.Length, this).queue;
                for(int i =head; i <temp.Length; i++)
                {
                    queue[i-head] = temp[i-head];
                }
                for(int i =0; i < head; i++)
                {
                    queue[i + head] = temp[i + head];
                }
                Enqueue(value);
                return;
            }
            queue[tail++] = value;
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
