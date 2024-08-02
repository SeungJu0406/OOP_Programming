namespace LevelTest4
{
    public class Map
    {
        enum MapName { Town, Castle, Guild, Shop, Cenetry, Forest, Grassland, Sea, SIZE }
        MatrixGraph mapGraph;
        List<MapName> route;
        List<MapName> crossroad;
        MapName nowMap;
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
            Console.WriteLine($"현재장소: {nowMap}");
            Console.Write($"이동경로:");
            for (int i = 0; i < route.Count; i++)
            {
                Console.Write($" {route[i]} >");
            }
            Console.WriteLine("\n");
            CreateChoice();
            for(int i = 0; i < crossroad.Count; i++)
            {
                Console.WriteLine($"{i+1}. {crossroad[i]}");
            }
        }






        private void CreateChoice()
        {
            for (int to = 0; to < mapGraph.graph.GetLength(1); to++)
            {
                if (mapGraph.IsConnect((int)nowMap, to))
                    crossroad.Add((MapName)to);
            }
        }
        public void MoveMap(int from, int to)
        {
            if (mapGraph.IsConnect(from, to))
            {
                route.Add((MapName)from);
                nowMap = (MapName)from;
            }
        }
        private void SaveMapData(MatrixGraph mapGraph)
        {
            mapGraph.Connect((int)MapName.Town, (int)MapName.Castle);
            mapGraph.Connect((int)MapName.Town, (int)MapName.Cenetry);

            mapGraph.Connect((int)MapName.Castle, (int)MapName.Town);
            mapGraph.Connect((int)MapName.Castle, (int)MapName.Guild);
            mapGraph.Connect((int)MapName.Castle, (int)MapName.Guild);
            mapGraph.Connect((int)MapName.Castle, (int)MapName.Forest);
            mapGraph.Connect((int)MapName.Castle, (int)MapName.Grassland);
            mapGraph.Connect((int)MapName.Castle, (int)MapName.Cenetry);

            mapGraph.Connect((int)MapName.Guild, (int)MapName.Shop);
            mapGraph.Connect((int)MapName.Guild, (int)MapName.Forest);
            mapGraph.Connect((int)MapName.Guild, (int)MapName.Castle);

            mapGraph.Connect((int)MapName.Shop, (int)MapName.Guild);
            mapGraph.Connect((int)MapName.Shop, (int)MapName.Forest);
            mapGraph.Connect((int)MapName.Shop, (int)MapName.Sea);

            mapGraph.Connect((int)MapName.Cenetry, (int)MapName.Town);
            mapGraph.Connect((int)MapName.Cenetry, (int)MapName.Castle);
            mapGraph.Connect((int)MapName.Cenetry, (int)MapName.Grassland);
            mapGraph.Connect((int)MapName.Cenetry, (int)MapName.Sea);

            mapGraph.Connect((int)MapName.Forest, (int)MapName.Shop);
            mapGraph.Connect((int)MapName.Forest, (int)MapName.Guild);
            mapGraph.Connect((int)MapName.Forest, (int)MapName.Castle);
            mapGraph.Connect((int)MapName.Forest, (int)MapName.Forest);

            mapGraph.Connect((int)MapName.Grassland, (int)MapName.Castle);
            mapGraph.Connect((int)MapName.Grassland, (int)MapName.Cenetry);
            mapGraph.Connect((int)MapName.Grassland, (int)MapName.Forest);
            mapGraph.Connect((int)MapName.Grassland, (int)MapName.Sea);

            mapGraph.Connect((int)MapName.Sea, (int)MapName.Shop);
            mapGraph.Connect((int)MapName.Sea, (int)MapName.Grassland);
            mapGraph.Connect((int)MapName.Sea, (int)MapName.Cenetry);
        }
    }
}
