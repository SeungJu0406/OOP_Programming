namespace StackAssignment2
{
    public class Program
    {
        static void Main(string[] args)
        {

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
            stack = new T[pastStack.stack.Length*2];
        }
        public void Push(T value)
        {
            if (index > stack.Length)
            {
                temp = stack;
                stack = new Stack<T>(index, this).stack;
                for(int i = 0; i < temp.Length; i++)
                {
                    stack[i] = stack[i];
                }
                Push(value);
                return;
            }
            stack[index++]=value;
        }
        public void Pop()
        {

        }

            
    }

}
