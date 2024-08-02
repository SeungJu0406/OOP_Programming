using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelTest4
{
    public abstract class Graph
    {
        public abstract void Connect(int from, int to);
        public abstract void DisConnect(int from, int to);
        public abstract bool IsConnect(int from, int to);
    }

    public class MatrixGraph : Graph
    {
        public bool[,] graph;

        public MatrixGraph(int node) 
        {
            graph = new bool[node, node];
        }
        public override void Connect(int from, int to) 
        {
            graph[from, to] = true;
        }
        public override void DisConnect(int from, int to)
        {
            graph[from, to] = false;
        }
        public override bool IsConnect(int from, int to)
        {
            return graph[from, to] == true;
        }
    }
    public class ListGraph : Graph
    {
        List<int>[] graph;
        public ListGraph(int node)
        {
            graph = new List<int>[node];
            for (int i = 0; i < graph.Length; i++) 
            {
                graph[i] = new List<int>();
            }
        }
        public override void Connect(int from, int to)
        {
            graph[from].Add(to);
        }
        public override void DisConnect(int from, int to)
        {
            graph[from].Remove(to);
        }
        public override bool IsConnect(int from, int to)
        {
            return graph[from].Contains(to);
        }
    }
}
