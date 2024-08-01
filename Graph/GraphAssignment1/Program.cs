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
            this.graph.Connect(0, 2);

            this.graph.Connect(1, 0);
            this.graph.Connect(1, 3);
            this.graph.Connect(1, 5);

            this.graph.Connect(2, 6);

            this.graph.Connect(4, 2);
            this.graph.Connect(4, 7);

            this.graph.Connect(5, 1);
            this.graph.Connect(5, 6);
            this.graph.Connect(5, 7); 

            this.graph.Connect(6, 2);
            this.graph.Connect(6, 5);
            this.graph.Connect(6, 7);
            this.graph.Connect(7, 4);
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
