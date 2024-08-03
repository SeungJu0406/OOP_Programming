namespace ListAssignment2
{
    public class Program
    {
        static void Main(string[] args)
        {
            JosePhus josePhus = new();
            josePhus.PrintJosePhus(7, 3);
        }
    }
    public class JosePhus
    {
        List<int> list;
        public void PrintJosePhus(int N, int K)
        {
            foreach (int i in CreateJosePhus(N, K))
            {
                Console.Write($"{i,-2}");
            }
            Console.WriteLine();
        }

        private List<int> CreateJosePhus(int N, int K)
        {
            int index = 0;
            int count = 0;
            int round =0;
            List<int> result = new List<int>(N);
            list = new List<int>(N);
            for (int i = 0; i < list.Capacity; i++)
            {
                list.Add(i + 1);
            }
            while (count < N)
            {                
                index++;
                if (index == K)
                {
                    result.Add(list[round]);
                    list.RemoveAt(round);
                    index = 0;
                    count++;
                }
                else
                {
                    round++;
                }
                if(round >= list.Count)
                    round = 0;
            }
            return result;
        }
    }
}
