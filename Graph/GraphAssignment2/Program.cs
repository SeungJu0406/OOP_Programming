namespace GraphAssignment2
{
    public class Program
    {
        static void Main(string[] args)
        {
           SampleGraph sample= new SampleGraph();
            sample.PrintGraph();
        }
    }

    public class SampleGraph
    {
        MatrixGraph graph;
        public SampleGraph()
        {
            graph = new MatrixGraph(8);
            ConnectGraph();
        }
        public void ConnectGraph()
        {
            graph.Connect(0,1);
            graph.Connect(0,3);
            graph.Connect(0,4);
            graph.Connect(1,3);
            graph.Connect(1,5);
            graph.Connect(1,6);
            graph.Connect(2,1);
            graph.Connect(2,4);
            graph.Connect(4,6);
            graph.Connect(5,6);
            graph.Connect(6,2);
            graph.Connect(7,5);
            graph.Connect(7,6);
        }
        public void PrintGraph()
        {
            for(int from = 0; from < graph.vertex.GetLength(0); from++)
            {
                Console.WriteLine($"{from}번 노드:");
                for (int to = 0; to < graph.vertex.GetLength(1); to++) 
                {
                    if(graph.IsConnect(from, to))
                        Console.WriteLine($"\t{to}번 노드");
                }
            }
        }
    }

    public class MatrixGraph
    {
        public bool[,] vertex {  get; set; }
        public MatrixGraph(int node)
        {
            vertex = new bool[node, node];
        }
        public void Connect(int from, int to)
        {
            vertex[from, to] = true;
        }
        public void DisConnect(int from, int to) 
        {
            vertex[from, to] = false;
        }
        public bool IsConnect(int from, int to)
        {
            return vertex[from, to];
        }
    }
}
