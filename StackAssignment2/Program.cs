namespace StackAssignment2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            Console.WriteLine(stack.Peek());
            stack.Pop();
            Console.WriteLine(stack.Peek());
            stack.Push(5);
            //stack.PrintStack();
        }
    }
    public class Stack<T>
    {
        T[] stack;
        T[] temp;
        int index = 0;
        public Stack()
        {
            index = 0;
            stack = new T[10];
        }
        public Stack(int pastIndex, Stack<T> pastStack)
        {
            index = pastIndex;
            stack = new T[pastStack.stack.Length * 2];
        }
        public void Push(T value)
        {
            if (index > stack.Length)
            {
                temp = stack;
                stack = new Stack<T>(index, this).stack;
                for (int i = 0; i < temp.Length; i++)
                {
                    stack[i] = stack[i];
                }
                Push(value);
                return;
            }
            stack[index++] = value;
        }
        public void Pop()
        {
            stack[index--] = default(T);
        }
        public T Peek()
        {
            return stack[index-1];
        }
        public void Clear()
        {
            Array.Clear(stack, 0, stack.Length);
        }
        public void PrintStack()
        {
            foreach (T t in stack)
            {
                Console.WriteLine(t);
            }
        }
    }
}