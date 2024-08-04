namespace GraphAssignment1
{
    public class Program
    {
        static void Main(string[] args)
        {
            SampleGraph sample = new SampleGraph();
            sample.PrintSample();
        }
    }

    public class SampleGraph
    {
        public ListGraph graph {  get; set; }
        public SampleGraph()
        {
            graph = new ListGraph(8);
            ConnectGraph();
        }
        public void ConnectGraph()
        {
            graph.ConnectBoth(0, 1); 
            graph.ConnectBoth(0, 3);
            graph.ConnectBoth(0, 4);
            graph.ConnectBoth(2, 4);
            graph.ConnectBoth(2, 5);
            graph.ConnectBoth(4, 7);
            graph.ConnectBoth(3, 7);
            graph.ConnectBoth(5, 7);
        }
        public void PrintSample() 
        {
            for (int from = 0; from < graph.vertex.Length; from++)
            {
                Console.WriteLine($"{from}번 노드: ");
                for (int to = 0; to < graph.vertex.Length; to++)
                {
                    if (graph.IsConnect(from, to))
                        Console.WriteLine($"\t{to}번 노드");
                }
            }
        }
    }

    public class ListGraph
    {
        public List<int>[] vertex { get; set; }
        public ListGraph(int node)
        {
            vertex = new List<int>[node];
            for (int i = 0; i < vertex.Length; i++)
            {
                vertex[i] = new List<int>();
            }
        }
        public void Connect(int from, int to)
        {
            vertex[from].Add(to);
        }
        public void ConnectBoth(int a, int b)
        {
            vertex[a].Add(b);
            vertex[b].Add(a);
        }
        public void Disconnect(int from, int to)
        {
            vertex[from].Remove(to);
        }
        public bool IsConnect(int from, int to)
        {
            return vertex[from].Contains(to);
        }
    }
}
