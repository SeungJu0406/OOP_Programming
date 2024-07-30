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
            queue.Enqueue(5);
            queue.PrintQueue();
        }
    }
    public class Queue<T>
    {
        T[] queue;
        T[] temp;
        int index;
        public Queue()
        {
            queue = new T[10];
            index = 0;
        }
        public Queue(int pastIndex, Queue<T> pastQueue)
        {
            queue = new T[pastQueue.queue.Length*2];
            index = pastIndex;
        }
        public void Enqueue(T value)
        {
            if (index >= queue.Length)
            {
                temp = queue;
                queue = new Queue<T>(index, this).queue;
                for (int i = 0; i < temp.Length; i++)
                {
                    queue[i] = temp[i];
                }
                Enqueue(value);
                return;
            }
            queue[index++] = value;
        }
        public void Dequeue()
        {
            for (int i = 0; i < queue.Length - 1; i++)
            {
                queue[i] = queue[i + 1];
            }
            queue[queue.Length - 1] = default(T);
            index--;
        }
        public T Peek()
        {
            return queue[0];
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
