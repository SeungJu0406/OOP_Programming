namespace LevelTest6
{
    public class Map 
    {
        enum MapName { Town, Castle, Guild, Shop, Cenetry, Forest, Grassland, Sea, SIZE }
        MatrixGraph mapGraph;
        List<MapData> route;
        List<MapData> crossroad;
        List<MapData> mapData;
        MapData nowMap;
        public Map()
        {
            mapGraph = new MatrixGraph(8);
            SaveMapLink(mapGraph);
            mapData = new List<MapData>(8);
            SaveMapData(mapData);
            nowMap = mapData[(int)MapName.Town];
            route = new List<MapData>(10);
            route.Add(nowMap);
            crossroad = new List<MapData>(8);           
        }

        public void PrintChoiceMap()
        {
            int order = 1;
            Console.Clear();
            Console.WriteLine("=============== 맵 이동 ==============");
            Console.WriteLine($"현재장소: {nowMap.name}");
            Console.Write($"이동경로:");
            for (int i = 0; i < route.Count; i++)
            {
                Console.Write($" {route[i].name} >");
            }
            Console.WriteLine("\n");
            CreateChoice();
            for (int i = 0; i < crossroad.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {crossroad[i].name}");
            }
            Console.WriteLine();
            Console.Write("이동할 장소를 선택하세요(뒤로가기 0, 입장하기 9): ");           
        }
        public void ChooseMap(Player player)
        {
            if (int.TryParse(Console.ReadLine(), out int key)) 
            {
                if (key == 0 && route.Count > 1)
                {
                    BackMap();
                }
                if (0 < key && key - 1 < crossroad.Count)
                {
                    MoveMap(nowMap.id, crossroad[key - 1].id);
                }
                if(key == 9)
                {
                    Enter(nowMap, player);
                }
            }
            return;
        }
        private void Enter(IEnter enterAble, Player player)
        {
            enterAble.Enter(player);
        }
        private void CreateChoice()
        {
            crossroad.Clear();
            for (int to = 0; to < mapGraph.graph.GetLength(1); to++)
            {
                if (mapGraph.IsConnect(nowMap.id, to))
                    crossroad.Add(mapData[to]);
            }
        }
        private void MoveMap(int from, int to)
        {
            if (mapGraph.IsConnect(from, to))
            {
                route.Add(mapData[to]);
                nowMap = (mapData[to]);
                crossroad.Clear();
            }
        }
        private void BackMap()
        {
            route.RemoveAt(route.Count - 1);
            nowMap = route[route.Count - 1];
        }
        private void SaveMapLink(MatrixGraph mapGraph)
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
        private void SaveMapData(List<MapData> mapData)
        {
            mapData.Insert((int)MapName.Town,new Town());
            mapData.Insert((int)MapName.Castle, new Castle());
            mapData.Insert((int)MapName.Guild, new Guild());
            mapData.Insert((int)MapName.Shop, new Shop());
            mapData.Insert((int)MapName.Cenetry, new Cenetry());
            mapData.Insert((int)MapName.Forest, new Forest());
            mapData.Insert((int)MapName.Grassland, new Grassland());
            mapData.Insert((int)MapName.Sea, new Sea());
        }
    }
}
