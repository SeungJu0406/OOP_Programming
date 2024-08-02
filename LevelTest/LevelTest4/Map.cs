namespace LevelTest4
{
    public class Map
    {
        protected enum MapName { Town, Castle, Guild, Shop, Cenetry, Forest, Grassland, Sea, SIZE }
        MatrixGraph mapGraph;
        List<MapName> route;
        List<MapName> crossroad;
        MapName nowMap;
        protected int id;
        protected string name;
        public Map()
        {
            mapGraph = new MatrixGraph(8);
            nowMap = MapName.Town;
            route = new List<MapName>(10);
            route.Add(nowMap);
            crossroad = new List<MapName>(8);
            SaveMapData(mapGraph);
        }

        public void PrintChoiceMap()
        {
            int order = 1;
            Console.Clear();
            Console.WriteLine("=============== 맵 이동 ==============");
            Console.WriteLine($"현재장소: {nowMap}");
            Console.Write($"이동경로:");
            for (int i = 0; i < route.Count; i++)
            {
                Console.Write($" {route[i]} >");
            }
            Console.WriteLine("\n");
            CreateChoice();
            for (int i = 0; i < crossroad.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {crossroad[i]}");
            }
            Console.WriteLine();
            Console.Write("이동할 장소를 선택하세요(뒤로가기 0): ");
        }
        public void ChooseMap(int key)
        {
            if (key == 0 && route.Count > 1)
            {
                BackMap();
            }
            if (0 < key && key - 1 < crossroad.Count)
            {
                MoveMap((int)nowMap, (int)crossroad[key-1]);
            }
            return;
        }


        private void CreateChoice()
        {
            crossroad.Clear();
            for (int to = 0; to < mapGraph.graph.GetLength(1); to++)
            {
                if (mapGraph.IsConnect((int)nowMap, to))
                    crossroad.Add((MapName)to);
            }
        }
        private void MoveMap(int from, int to)
        {
            if (mapGraph.IsConnect(from, to))
            {
                route.Add((MapName)to);
                nowMap = (MapName)to;
                crossroad.Clear();
            }
        }
        private void BackMap()
        {
            route.RemoveAt(route.Count - 1);
            nowMap = route[route.Count - 1];
        }
        private void SaveMapData(MatrixGraph mapGraph)
        {
            mapGraph.ConnectBoth((int)MapName.Town, (int)MapName.Castle);
            mapGraph.ConnectBoth((int)MapName.Town, (int)MapName.Cenetry);
            mapGraph.ConnectBoth((int)MapName.Castle, (int)MapName.Guild);
            mapGraph.ConnectBoth((int)MapName.Castle, (int)MapName.Forest);
            mapGraph.ConnectBoth((int)MapName.Castle, (int)MapName.Grassland);
            mapGraph.ConnectBoth((int)MapName.Castle, (int)MapName.Cenetry);
            mapGraph.ConnectBoth((int)MapName.Guild, (int)MapName.Shop);
            mapGraph.ConnectBoth((int)MapName.Guild, (int)MapName.Forest);
            mapGraph.ConnectBoth((int)MapName.Shop, (int)MapName.Forest);
            mapGraph.ConnectBoth((int)MapName.Shop, (int)MapName.Sea);
            mapGraph.ConnectBoth((int)MapName.Cenetry, (int)MapName.Grassland);
            mapGraph.ConnectBoth((int)MapName.Cenetry, (int)MapName.Sea);
            mapGraph.ConnectBoth((int)MapName.Forest, (int)MapName.Grassland);
            mapGraph.ConnectBoth((int)MapName.Grassland, (int)MapName.Sea);
        }
    }
}
